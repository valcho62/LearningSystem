
using LearningSystem.Data;

namespace LearningSystem.Services
{
    public abstract class Service
    {
        protected LearningSystemContex Contex { get; }

        public Service()
        {
            this.Contex = new LearningSystemContex();
        }
    }
}
