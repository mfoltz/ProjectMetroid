// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.TriggerData
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
  public struct TriggerData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CallerEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_FunctionHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
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
    public TriggerTypeEnum Type;
    [FieldOffset(40)]
    public float3 StartPosition;
    [FieldOffset(52)]
    public float3 EndPosition;
    [FieldOffset(64)]
    public float Radius;

    static TriggerData()
    {
      Il2CppClassPointerStore<TriggerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (TriggerData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerData>.NativeClassPtr);
      TriggerData.NativeFieldInfoPtr_CallerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (CallerEntity));
      TriggerData.NativeFieldInfoPtr_FunctionHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (FunctionHash));
      TriggerData.NativeFieldInfoPtr_ContextEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (ContextEntity));
      TriggerData.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (HitFilter));
      TriggerData.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (CollisionFilter));
      TriggerData.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (Type));
      TriggerData.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (StartPosition));
      TriggerData.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (EndPosition));
      TriggerData.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TriggerData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
