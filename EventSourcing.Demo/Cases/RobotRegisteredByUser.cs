using EventSourcing.Demo.Framework;

namespace EventSourcing.Demo.Cases
{
    public sealed class RobotRegisteredByUser
    {
        public static readonly EventType<RobotRegisteredByUser> EventType = "RobotRegistered";

        public RobotRegisteredByUser(
            EndUserId registeredToId,
            UserId registeredById,
            string name,
            string integrator,
            string description
        )
        {
            RegisteredToId = registeredToId;
            RegisteredById = registeredById;

            Name = name;

            Integrator = integrator;
            Description = description;
        }

        public EndUserId RegisteredToId { get; }
        public UserId RegisteredById { get; }

        public string Name { get; }

        public string Integrator { get; }
        
        public string Description { get; }
    }
}