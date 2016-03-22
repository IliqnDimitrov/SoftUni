namespace VegetableNinja.Core
{
    using System;
    using System.Linq;
    using VegetableNinja.Interfaces;
    using VegetableNinja.Models.Vegetables;

    public class Engine : IEngine
    {
        private INinjaFactory ninjaFactory;
        private IData data;
        private IFieldFactory fieldFactory;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(INinjaFactory ninjaFactory, IData data, IFieldFactory fieldFactory, IInputReader reader, IOutputWriter writer)
        {
            this.ninjaFactory = ninjaFactory;
            this.data = data;
            this.fieldFactory = fieldFactory;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            //Reading Players
            for (int i = 0; i < 2; i++)
            {
                string input = this.reader.ReadLine();
                INinja player = this.ninjaFactory.CreateNinja(input);
                this.data.AddNinjas(player);
            }

            //Reading Field
            string[] fieldRowCol = this.reader.ReadLine().Split();
            int fieldRow = int.Parse(fieldRowCol[0]);
            int fieldCol = int.Parse(fieldRowCol[1]);
            IField field = this.fieldFactory.CreateField(fieldRow, fieldCol);
            this.data.AddFIeld(field);

            //FindingPostionsInField
            this.FindingPostionInField();

            //Reading Moves
            while (true)
            {
                char[] input = this.reader.ReadLine().ToCharArray();
                for (int i = 0; i < input.Length; i++)
                {
                    if (this.data.Ninjas.First().Stamina == 0)
                    {
                        this.data.Ninjas.First().Stamina = 1;
                    }
                    if (this.data.Ninjas.First().Stamina > 0)
                    {
                    done:
                        if (i == input.Length)
                        {
                            break;
                        }
                        this.ExecuteCommand(input[i], this.data.Ninjas.First());
                        if (this.data.Ninjas.First().Stamina > 0)
                        {
                            i++;
                            goto done;
                        }
                        this.ApplyVegatables(this.data.Ninjas.First());
                        this.data.Ninjas.First().Vegetables.Clear();
                        i++;
                    }

                    if (this.data.Ninjas.Last().Stamina == 0)
                    {
                        this.data.Ninjas.Last().Stamina = 1;
                    }
                    if (this.data.Ninjas.Last().Stamina > 0)
                    {
                    done2:
                        if (i == input.Length)
                        {
                            break;
                        }
                        this.ExecuteCommand(input[i], this.data.Ninjas.Last());
                        if (this.data.Ninjas.Last().Stamina > 0)
                        {
                            i++;
                            goto done2;
                        }

                        this.ApplyVegatables(this.data.Ninjas.Last());
                        this.data.Ninjas.Last().Vegetables.Clear();
                    }                  
                }                
            }
        }

        private void ApplyVegatables(INinja ninja)
        {
            foreach (var item in ninja.Vegetables)
            {
                item.VegetableEffect(ninja);
            }
        }

        private void FindingPostionInField()
        {
            foreach (var item in this.data.Fields)
            {
                foreach (var field in item.GameField)
                {
                    for (int i = 0; i < item.FieldRows; i++)
                    {
                        for (int j = 0; j < item.FieldCols; j++)
                        {
                            if (item.GameField[i][j] == this.data.Ninjas.First().Name[0])
                            {
                                this.data.Ninjas.First().RowPositionField = i;
                                this.data.Ninjas.First().ColPositionFIeld = j;
                            }
                            else if (item.GameField[i][j] == this.data.Ninjas.Last().Name[0])
                            {
                                this.data.Ninjas.Last().RowPositionField = i;
                                this.data.Ninjas.Last().ColPositionFIeld = j;
                            }
                        }
                    }
                }
            }
        }

        private void ExecuteCommand(char input, INinja player)
        {
            switch (input)
            {
                case 'U':
                    this.MoveUp(player);
                    break;
                case 'D':
                    this.MoveDown(player);
                    break;
                case 'L':
                    this.MoveLeft(player);
                    break;
                case 'R':
                    this.MoveRight(player);
                    break;
                default:
                    throw new ArgumentException("Unknown Command");
            }
        }

        private void MoveUp(INinja player)
        {
            if (player.Stamina - 1 < 0)
            {
                player.Stamina = 0;
            }
            else
            {
                player.Stamina -= 1;
            }
            player.RowPositionField -= 1;
            if (player.RowPositionField < 0)
            {
                player.RowPositionField = 0;
            }
            this.CheckIfFoundOtherPlayer(player);           
            int row = player.RowPositionField;
            int col = player.ColPositionFIeld;
            char possibleVegetable = this.data.Fields.First().GameField[row][col];
            this.AddVegetable(possibleVegetable, player);
        }

        private void MoveDown(INinja player)
        {
            if (player.Stamina - 1 < 0)
            {
                player.Stamina = 0;
            }
            else
            {
                player.Stamina -= 1;
            }
            player.RowPositionField += 1;
            this.CheckIfFoundOtherPlayer(player);          
            int row = player.RowPositionField;
            int col = player.ColPositionFIeld;
            if (this.data.Fields.First().FieldRows - 1 < row)
            {
                row--;
                player.RowPositionField -= 1;
            }
            char possibleVegetable = this.data.Fields.First().GameField[row][col];
            this.AddVegetable(possibleVegetable, player);
        }

        private void MoveLeft(INinja player)
        {
            if (player.Stamina - 1 < 0)
            {
                player.Stamina = 0;
            }
            else
            {
                player.Stamina -= 1;
            }
            player.ColPositionFIeld -= 1;
            if (player.ColPositionFIeld < 0)
            {
                player.ColPositionFIeld = 0;
            }
            this.CheckIfFoundOtherPlayer(player);           
            int row = player.RowPositionField;
            int col = player.ColPositionFIeld;
            char possibleVegetable = this.data.Fields.First().GameField[row][col];
            this.AddVegetable(possibleVegetable, player);
        }

        private void MoveRight(INinja player)
        {
            if (player.Stamina - 1 < 0)
            {
                player.Stamina = 0;
            }
            else
            {
                player.Stamina -= 1;
            }
            player.ColPositionFIeld += 1;           
            this.CheckIfFoundOtherPlayer(player);
            int row = player.RowPositionField;
            int col = player.ColPositionFIeld;
            if (this.data.Fields.First().FieldCols - 1 < col)
            {
                col--;
                player.ColPositionFIeld -= 1;
            }
            char possibleVegetable = this.data.Fields.First().GameField[row][col];
            this.AddVegetable(possibleVegetable, player);
        }

        private void AddVegetable(char possibleVegetable, INinja player)
        {
            switch (possibleVegetable)
            {
                case 'A':
                    player.Vegetables.Add(new Asparagus());
                    break;
                case 'B':
                    player.Vegetables.Add(new Broccoli());
                    break;
                case 'C':
                    player.Vegetables.Add(new CherryBerry());;
                    break;
                case 'M':
                    player.Vegetables.Add(new Mushroom());
                    break;
                case 'R':
                    player.Vegetables.Add(new Royal());
                    break;
            }
        }

        private void CheckIfFoundOtherPlayer(INinja attacker)
        {
            INinja attackerNinja = attacker;
            var findingDefendingNinja = this.data.Ninjas.Where(x => x.Name != attackerNinja.Name);
            INinja defenderNinja = findingDefendingNinja.First();
            if (attackerNinja.RowPositionField == defenderNinja.RowPositionField && attackerNinja.ColPositionFIeld == defenderNinja.ColPositionFIeld)
            {
                if (attackerNinja.Power == defenderNinja.Power)
                {
                    PrintWinner(attackerNinja);
                }
                else if (attackerNinja.Power > defenderNinja.Power)
                {
                    PrintWinner(attackerNinja);
                }
                else if (attackerNinja.Power < defenderNinja.Power)
                {
                    PrintWinner(defenderNinja);
                }
            }
        }

        private void PrintWinner(INinja winner)
        {
            this.writer.Print(String.Format("Winner: {0}", winner.Name));
            this.writer.Print(String.Format("Power: {0}", winner.Power));
            this.writer.Print(String.Format("Stamina: {0}", winner.Stamina));
            Environment.Exit(0);
        }
    }
}