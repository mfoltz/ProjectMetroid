// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.Pick
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Physics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Pick
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Normal;
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float3 Position;
    [FieldOffset(20)]
    public float3 Normal;
    [FieldOffset(32)]
    public CollisionFilterFlags Category;

    static Pick()
    {
      Il2CppClassPointerStore<Pick>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Physics", nameof (Pick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pick>.NativeClassPtr);
      Pick.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pick>.NativeClassPtr, nameof (Entity));
      Pick.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pick>.NativeClassPtr, nameof (Position));
      Pick.NativeFieldInfoPtr_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pick>.NativeClassPtr, nameof (Normal));
      Pick.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pick>.NativeClassPtr, nameof (Category));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Pick>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
