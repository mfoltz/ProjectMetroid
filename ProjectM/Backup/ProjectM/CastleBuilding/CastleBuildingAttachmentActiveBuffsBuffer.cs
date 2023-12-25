// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachmentActiveBuffsBuffer
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
  public struct CastleBuildingAttachmentActiveBuffsBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ParentEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffEntity;
    [FieldOffset(0)]
    public Entity ParentEntity;
    [FieldOffset(8)]
    public Entity ChildEntity;
    [FieldOffset(16)]
    public Entity BuffEntity;

    static CastleBuildingAttachmentActiveBuffsBuffer()
    {
      Il2CppClassPointerStore<CastleBuildingAttachmentActiveBuffsBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachmentActiveBuffsBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentActiveBuffsBuffer>.NativeClassPtr);
      CastleBuildingAttachmentActiveBuffsBuffer.NativeFieldInfoPtr_ParentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentActiveBuffsBuffer>.NativeClassPtr, nameof (ParentEntity));
      CastleBuildingAttachmentActiveBuffsBuffer.NativeFieldInfoPtr_ChildEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentActiveBuffsBuffer>.NativeClassPtr, nameof (ChildEntity));
      CastleBuildingAttachmentActiveBuffsBuffer.NativeFieldInfoPtr_BuffEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentActiveBuffsBuffer>.NativeClassPtr, nameof (BuffEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentActiveBuffsBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
