// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.Trigger
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Trigger
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    [FieldOffset(0)]
    public Entity CallerEntity;
    [FieldOffset(8)]
    public int FunctionHash;
    [FieldOffset(12)]
    public Entity ContextEntity;
    [FieldOffset(20)]
    public HitFilter HitFilter;
    [FieldOffset(24)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(36)]
    public float3 Offset;

    static Trigger()
    {
      Il2CppClassPointerStore<Trigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (Trigger));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger>.NativeClassPtr);
      Trigger.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, nameof (CallerEntity));
      Trigger.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, nameof (FunctionHash));
      Trigger.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, nameof (ContextEntity));
      Trigger.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, nameof (HitFilter));
      Trigger.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, nameof (CollisionFilter));
      Trigger.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, nameof (Offset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Trigger>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
