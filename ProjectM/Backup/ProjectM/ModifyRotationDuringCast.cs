// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyRotationDuringCast
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
  public struct ModifyRotationDuringCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastRotationData;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostCastRotationData;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastModifyRotationEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_PostCastModifyRotationEntity;
    [FieldOffset(0)]
    public ModifyRotation CastRotationData;
    [FieldOffset(64)]
    public ModifyRotation PostCastRotationData;
    [FieldOffset(128)]
    public Entity CastModifyRotationEntity;
    [FieldOffset(136)]
    public Entity PostCastModifyRotationEntity;

    static ModifyRotationDuringCast()
    {
      Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyRotationDuringCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr);
      ModifyRotationDuringCast.NativeFieldInfoPtr_CastRotationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr, nameof (CastRotationData));
      ModifyRotationDuringCast.NativeFieldInfoPtr_PostCastRotationData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr, nameof (PostCastRotationData));
      ModifyRotationDuringCast.NativeFieldInfoPtr_CastModifyRotationEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr, nameof (CastModifyRotationEntity));
      ModifyRotationDuringCast.NativeFieldInfoPtr_PostCastModifyRotationEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr, nameof (PostCastModifyRotationEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyRotationDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
