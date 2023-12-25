// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachmentRemovedEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleBuildingAttachmentRemovedEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildEntity;
    [FieldOffset(0)]
    public Entity ParentEntity;
    [FieldOffset(8)]
    public Entity ChildEntity;

    static CastleBuildingAttachmentRemovedEvent()
    {
      Il2CppClassPointerStore<CastleBuildingAttachmentRemovedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachmentRemovedEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentRemovedEvent>.NativeClassPtr);
      CastleBuildingAttachmentRemovedEvent.NativeFieldInfoPtr_ParentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentRemovedEvent>.NativeClassPtr, nameof (ParentEntity));
      CastleBuildingAttachmentRemovedEvent.NativeFieldInfoPtr_ChildEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentRemovedEvent>.NativeClassPtr, nameof (ChildEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentRemovedEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
