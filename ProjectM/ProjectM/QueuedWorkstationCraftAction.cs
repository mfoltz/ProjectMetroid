// Decompiled with JetBrains decompiler
// Type: ProjectM.QueuedWorkstationCraftAction
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct QueuedWorkstationCraftAction
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InitiateUser;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemsStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemRequirementsCount;
    [FieldOffset(0)]
    public Entity InitiateUser;
    [FieldOffset(8)]
    public PrefabGUID RecipeGuid;
    [FieldOffset(12)]
    public float ProgressTime;
    [FieldOffset(16)]
    public CraftingStatus Status;
    [FieldOffset(20)]
    public int ItemsStartIndex;
    [FieldOffset(24)]
    public int ItemRequirementsCount;

    static QueuedWorkstationCraftAction()
    {
      Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (QueuedWorkstationCraftAction));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr);
      QueuedWorkstationCraftAction.NativeFieldInfoPtr_InitiateUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, nameof (InitiateUser));
      QueuedWorkstationCraftAction.NativeFieldInfoPtr_RecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, nameof (RecipeGuid));
      QueuedWorkstationCraftAction.NativeFieldInfoPtr_ProgressTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, nameof (ProgressTime));
      QueuedWorkstationCraftAction.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, nameof (Status));
      QueuedWorkstationCraftAction.NativeFieldInfoPtr_ItemsStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, nameof (ItemsStartIndex));
      QueuedWorkstationCraftAction.NativeFieldInfoPtr_ItemRequirementsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, nameof (ItemRequirementsCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueuedWorkstationCraftAction>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
