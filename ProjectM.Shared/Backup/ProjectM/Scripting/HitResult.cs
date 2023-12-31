// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.HitResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HitResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float3 Position;

    static HitResult()
    {
      Il2CppClassPointerStore<HitResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (HitResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitResult>.NativeClassPtr);
      HitResult.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitResult>.NativeClassPtr, nameof (Entity));
      HitResult.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitResult>.NativeClassPtr, nameof (Position));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
