using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
      return !knightIsAwake; // Se knightIsAwake for true !knightIsAwake será false
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return knightIsAwake || archerIsAwake || prisonerIsAwake; // Se ambos forem verdadeiros retornará true
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake  && prisonerIsAwake; // Se !prisonerIsAwake for false e prisonerIsAwake true será retornado true
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
            return (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake); // Se ma das condições forem veraddeiras retorna true
    
}
}
