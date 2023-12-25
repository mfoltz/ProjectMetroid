// Decompiled with JetBrains decompiler
// Type: ProjectM.JewelCraftingStation
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct JewelCraftingStation
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveRecipeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftedItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_CraftedItemTypeGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InactiveSequenceState;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCrafting_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasItemWaiting_Public_get_Boolean_0;
    [FieldOffset(0)]
    public PrefabGUID ActiveRecipeGuid;
    [FieldOffset(4)]
    public float CraftProgress;
    [FieldOffset(8)]
    public CraftingStatus Status;
    [FieldOffset(12)]
    public NetworkedEntity CraftedItem;
    [FieldOffset(24)]
    public PrefabGUID CraftedItemTypeGuid;
    [FieldOffset(28)]
    public SequenceGUID ActiveSequenceGuid;
    [FieldOffset(32)]
    public SequenceState ActiveSequenceState;
    [FieldOffset(40)]
    public SequenceGUID InactiveSequenceGuid;
    [FieldOffset(44)]
    public SequenceState InactiveSequenceState;

    public unsafe bool IsCrafting
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 996448, RefRangeEnd = 996452, XrefRangeStart = 996448, XrefRangeEnd = 996452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelCraftingStation.NativeMethodInfoPtr_get_IsCrafting_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasItemWaiting
    {
      [CallerCount(6), CachedScanResults(RefRangeStart = 1046608, RefRangeEnd = 1046614, XrefRangeStart = 1046605, XrefRangeEnd = 1046608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JewelCraftingStation.NativeMethodInfoPtr_get_HasItemWaiting_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static JewelCraftingStation()
    {
      Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JewelCraftingStation));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr);
      JewelCraftingStation.NativeFieldInfoPtr_ActiveRecipeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (ActiveRecipeGuid));
      JewelCraftingStation.NativeFieldInfoPtr_CraftProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (CraftProgress));
      JewelCraftingStation.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (Status));
      JewelCraftingStation.NativeFieldInfoPtr_CraftedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (CraftedItem));
      JewelCraftingStation.NativeFieldInfoPtr_CraftedItemTypeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (CraftedItemTypeGuid));
      JewelCraftingStation.NativeFieldInfoPtr_ActiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (ActiveSequenceGuid));
      JewelCraftingStation.NativeFieldInfoPtr_ActiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (ActiveSequenceState));
      JewelCraftingStation.NativeFieldInfoPtr_InactiveSequenceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (InactiveSequenceGuid));
      JewelCraftingStation.NativeFieldInfoPtr_InactiveSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, nameof (InactiveSequenceState));
      JewelCraftingStation.NativeMethodInfoPtr_get_IsCrafting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, 100682017);
      JewelCraftingStation.NativeMethodInfoPtr_get_HasItemWaiting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, 100682018);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JewelCraftingStation>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
