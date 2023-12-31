// Decompiled with JetBrains decompiler
// Type: ProjectM.FormationOffsetBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FormationOffsetBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitialRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_FollowIndex;
    [FieldOffset(0)]
    public float3 Offset;
    [FieldOffset(12)]
    public quaternion Rotation;
    [FieldOffset(28)]
    public quaternion InitialRotation;
    [FieldOffset(44)]
    public Nullable_Unboxed<float3> Position;
    [FieldOffset(60)]
    public int FollowIndex;

    static FormationOffsetBuffer()
    {
      Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (FormationOffsetBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr);
      FormationOffsetBuffer.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr, nameof (Offset));
      FormationOffsetBuffer.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr, nameof (Rotation));
      FormationOffsetBuffer.NativeFieldInfoPtr_InitialRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr, nameof (InitialRotation));
      FormationOffsetBuffer.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr, nameof (Position));
      FormationOffsetBuffer.NativeFieldInfoPtr_FollowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr, nameof (FollowIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FormationOffsetBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
