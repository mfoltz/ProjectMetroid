// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionCandidate
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastOptionCandidate
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DistanceSquared;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float DistanceSquared;

    static CastOptionCandidate()
    {
      Il2CppClassPointerStore<CastOptionCandidate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionCandidate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidate>.NativeClassPtr);
      CastOptionCandidate.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCandidate>.NativeClassPtr, nameof (Entity));
      CastOptionCandidate.NativeFieldInfoPtr_DistanceSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCandidate>.NativeClassPtr, nameof (DistanceSquared));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidate>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
