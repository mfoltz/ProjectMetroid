// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroCandidateBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AggroCandidateBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSq;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    [FieldOffset(0)]
    public float3 Position;
    [FieldOffset(12)]
    public float DistanceSq;
    [FieldOffset(16)]
    public Entity Entity;

    static AggroCandidateBufferElement()
    {
      Il2CppClassPointerStore<AggroCandidateBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroCandidateBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroCandidateBufferElement>.NativeClassPtr);
      AggroCandidateBufferElement.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroCandidateBufferElement>.NativeClassPtr, nameof (Position));
      AggroCandidateBufferElement.NativeFieldInfoPtr_DistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroCandidateBufferElement>.NativeClassPtr, nameof (DistanceSq));
      AggroCandidateBufferElement.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroCandidateBufferElement>.NativeClassPtr, nameof (Entity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AggroCandidateBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
