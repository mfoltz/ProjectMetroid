// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.AttachTileModelData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AttachTileModelData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildEntityToAttach;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentEntityAttachingTo;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachTo;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    [FieldOffset(0)]
    public PlacementEntityId ChildEntityToAttach;
    [FieldOffset(16)]
    public PlacementEntityId ParentEntityAttachingTo;
    [FieldOffset(32)]
    public CastleBuildingAttachSettings AttachSettings;
    [FieldOffset(40)]
    public PlacementTypeData PlacementTypes;
    [FieldOffset(80)]
    public PlacementTypeData AttachTo;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794484, XrefRangeEnd = 794513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AttachTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static AttachTileModelData()
    {
      Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding.Placement", nameof (AttachTileModelData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr);
      AttachTileModelData.NativeFieldInfoPtr_ChildEntityToAttach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, nameof (ChildEntityToAttach));
      AttachTileModelData.NativeFieldInfoPtr_ParentEntityAttachingTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, nameof (ParentEntityAttachingTo));
      AttachTileModelData.NativeFieldInfoPtr_AttachSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, nameof (AttachSettings));
      AttachTileModelData.NativeFieldInfoPtr_PlacementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, nameof (PlacementTypes));
      AttachTileModelData.NativeFieldInfoPtr_AttachTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, nameof (AttachTo));
      AttachTileModelData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, 100670054);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachTileModelData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
