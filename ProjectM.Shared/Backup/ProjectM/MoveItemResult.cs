// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveItemResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

#nullable disable
namespace ProjectM
{
  public enum MoveItemResult
  {
    Success_Complete,
    Success_Partial,
    Failed_FromInventoryDoesNotExist,
    Failed_FromIndexOutOfRange,
    Failed_ToInventoryDoesNotExist,
    Failed_ToIndexOutOfRange,
    Failed_FromItemDoesNotExist,
    Failed_NoItemAtFromIndex,
    Failed_ItemIsSoulBound,
    Failed_BlockedByRelicRules,
    Failed_ToRestrictedIndexOutOfRange,
    Failed_FromRestrictedIndexOutOfRange,
    Failed_RestrictionsNotMet,
    Failed_SameInventoryAndSlot,
    Failed,
  }
}
