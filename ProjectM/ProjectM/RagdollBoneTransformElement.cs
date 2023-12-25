// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollBoneTransformElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RagdollBoneTransformElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    [FieldOffset(0)]
    public Vector3 Position;
    [FieldOffset(12)]
    public Quaternion Rotation;

    static RagdollBoneTransformElement()
    {
      Il2CppClassPointerStore<RagdollBoneTransformElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollBoneTransformElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBoneTransformElement>.NativeClassPtr);
      RagdollBoneTransformElement.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneTransformElement>.NativeClassPtr, nameof (Position));
      RagdollBoneTransformElement.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneTransformElement>.NativeClassPtr, nameof (Rotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollBoneTransformElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
