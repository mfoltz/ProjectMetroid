// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachmentAddedEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleBuildingAttachmentAddedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PlacementTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachTo;
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildEntity;
    [FieldOffset(0)]
    public PlacementTypeData PlacementTypes;
    [FieldOffset(40)]
    public PlacementTypeData AttachTo;
    [FieldOffset(80)]
    public Entity ParentEntity;
    [FieldOffset(88)]
    public Entity ChildEntity;

    static CastleBuildingAttachmentAddedEvent()
    {
      Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachmentAddedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr);
      CastleBuildingAttachmentAddedEvent.NativeFieldInfoPtr_PlacementTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr, nameof (PlacementTypes));
      CastleBuildingAttachmentAddedEvent.NativeFieldInfoPtr_AttachTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr, nameof (AttachTo));
      CastleBuildingAttachmentAddedEvent.NativeFieldInfoPtr_ParentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr, nameof (ParentEntity));
      CastleBuildingAttachmentAddedEvent.NativeFieldInfoPtr_ChildEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr, nameof (ChildEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentAddedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
