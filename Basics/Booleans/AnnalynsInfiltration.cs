using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake == true){
            return false;
        }else{
        return true;
        }
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake == true || archerIsAwake == true || prisonerIsAwake){
            return true;
        }else{
        return false;
        }
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
      if(archerIsAwake == false && prisonerIsAwake == true){
          return true;
          }else{
      return false;         
          
    }
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(knightIsAwake == true && archerIsAwake == true && prisonerIsAwake == true && petDogIsPresent == true){
            return false;
        
        }else if(knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == false && petDogIsPresent == true){
         return true;
        }else if(knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == true){
         return true;
        }else if(knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == false && petDogIsPresent == true){
         return true;
        }else if(knightIsAwake == true && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == true){
         return true;
        }else if(knightIsAwake == true && archerIsAwake == true && prisonerIsAwake == false && petDogIsPresent == true){
         return false;
        }
    else if(knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true && petDogIsPresent == false){
         return true;
        } 
    
        return false;
    }
}
