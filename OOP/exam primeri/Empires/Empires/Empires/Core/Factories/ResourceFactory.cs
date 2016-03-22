using System;
using Empires.Enum;
using Empires.Interfaces;
using Empires.Models;

namespace Empires.Core.Factories
{
    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            var resource = new Resource(resourceType, quantity);

            return resource; 
        }
    }
}