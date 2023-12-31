// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleBuildingAttachSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveWithParentWhenAttached;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyWithParentWhenAttached;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkDestroyToParentWhenAttached;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictMoveWhenAttached;
    private static readonly System.IntPtr NativeFieldInfoPtr_RestrictDismantleWhenAttached;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveWithParentAlsoMovesOtherParents;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_CastleBuildingAttachSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public bool MoveWithParentWhenAttached;
    [FieldOffset(1)]
    public bool DestroyWithParentWhenAttached;
    [FieldOffset(2)]
    public bool LinkDestroyToParentWhenAttached;
    [FieldOffset(3)]
    public bool RestrictMoveWhenAttached;
    [FieldOffset(4)]
    public bool RestrictDismantleWhenAttached;
    [FieldOffset(5)]
    public bool MoveWithParentAlsoMovesOtherParents;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 793967, RefRangeEnd = 793975, XrefRangeStart = 793967, XrefRangeEnd = 793967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleBuildingAttachSettings Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachSettings.NativeMethodInfoPtr_Default_Public_Static_CastleBuildingAttachSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleBuildingAttachSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793975, XrefRangeEnd = 794006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static CastleBuildingAttachSettings()
    {
      Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr);
      CastleBuildingAttachSettings.NativeFieldInfoPtr_MoveWithParentWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, nameof (MoveWithParentWhenAttached));
      CastleBuildingAttachSettings.NativeFieldInfoPtr_DestroyWithParentWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, nameof (DestroyWithParentWhenAttached));
      CastleBuildingAttachSettings.NativeFieldInfoPtr_LinkDestroyToParentWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, nameof (LinkDestroyToParentWhenAttached));
      CastleBuildingAttachSettings.NativeFieldInfoPtr_RestrictMoveWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, nameof (RestrictMoveWhenAttached));
      CastleBuildingAttachSettings.NativeFieldInfoPtr_RestrictDismantleWhenAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, nameof (RestrictDismantleWhenAttached));
      CastleBuildingAttachSettings.NativeFieldInfoPtr_MoveWithParentAlsoMovesOtherParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, nameof (MoveWithParentAlsoMovesOtherParents));
      CastleBuildingAttachSettings.NativeMethodInfoPtr_Default_Public_Static_CastleBuildingAttachSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, 100669985);
      CastleBuildingAttachSettings.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, 100669986);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
