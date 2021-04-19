using RabbitPopulationSimulation.Concrete;
using RabbitPopulationSimulation.Enum;
using RabbitPopulationSimulation.Rabbit;
using System;

namespace RabbitPopulationSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Run();
        }
        public static void Run()
        {
            var configuration = RPSStartup.Builder().Build();
            new Statistics(configuration).getStatisticConfiguration();

            Coop coop = new Coop();
            coop.getGenderRabbits(Gender.MALE);
            coop.getGenderRabbits(Gender.FEMALE);

            for (int month = 0; month <= Statistics.months; month++)
            {
                if (coop.femaleRabbits.Count > 0)
                {
                    int newBornFemaleRabbit = 0;
                    int newBornMaleRabbit = 0;

                    coop.femaleRabbits?.ForEach(femaleRabbit =>
                    {
                        if (femaleRabbit.getLoseofFertility() > femaleRabbit.getAge() && femaleRabbit.getAge() > 0)
                        {
                            newBornFemaleRabbit += coop.getNumberofNewbornRabbits()
                                    * coop.getPercentageofRabbitsBorn() / 100;
                            newBornMaleRabbit += coop.getNumberofNewbornRabbits()
                                    * (100 - coop.getPercentageofRabbitsBorn()) / 100;
                        }
                    });

                    for (int i = 0; i < newBornFemaleRabbit; i++)
                        coop.getGenderRabbits(Gender.FEMALE);

                    for (int i = 0; i < newBornMaleRabbit; i++)
                        coop.getGenderRabbits(Gender.MALE);

                    RabbitAggregate<FemaleRabbit> femaleRabbitAggregate = new RabbitAggregate<FemaleRabbit>(coop.femaleRabbits);
                    var femaleRabbitIterator = femaleRabbitAggregate.GetIterator();
                    femaleRabbitIterator.First();
                    while (femaleRabbitIterator.IsDone())
                    {
                        FemaleRabbit femaleRabbit = femaleRabbitIterator.CurrentItem();
                        if (femaleRabbit.getAge() >= femaleRabbit.getLifetime())
                            femaleRabbitIterator.Remove();
                        else
                        {
                            if (month != Statistics.months)
                                femaleRabbit.age += Statistics.timeofPregnancy;
                        }
                        femaleRabbitIterator.Next();
                    }

                    RabbitAggregate<MaleRabbit> maleRabbitAggregate = new RabbitAggregate<MaleRabbit>(coop.maleRabbits);
                    var maleRabbitIterator = maleRabbitAggregate.GetIterator();
                    maleRabbitIterator.First();
                    while (maleRabbitIterator.IsDone())
                    {
                        MaleRabbit maleRabbit = maleRabbitIterator.CurrentItem();
                        if (maleRabbit.getAge() >= maleRabbit.getLifetime())
                            maleRabbitIterator.Remove();
                        else
                        {
                            if (month != Statistics.months)
                                maleRabbit.age += Statistics.timeofPregnancy;
                        }
                        maleRabbitIterator.Next();
                    }
                }
                month += Statistics.timeofPregnancy;
            }

            for (int i = 0; i <= Statistics.months; i++)
            {
                int numberFemale = 0;
                int numberMale = 0;

                coop.femaleRabbits?.ForEach(femaleRabbit =>
                {
                    if (femaleRabbit.getAge() == i)
                        numberFemale++;
                });

                coop.maleRabbits?.ForEach(maleRabbit =>
                {
                    if (maleRabbit.getAge() == i)
                        numberMale++;
                });

                Console.WriteLine(i + " aylık " + numberFemale + " dişi " + numberMale + " erkek tavşan");
            }
            Console.ReadLine();
        }
    }
}