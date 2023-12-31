// Decompiled with JetBrains decompiler
// Type: ProjectM.HitTrigger
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
  public struct HitTrigger
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HitTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Handled;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ignore;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastIndex;
    [FieldOffset(0)]
    public double HitTime;
    [FieldOffset(8)]
    public Entity Target;
    [FieldOffset(16)]
    public float3 OriginPosition;
    [FieldOffset(28)]
    public float3 CollisionPosition;
    [FieldOffset(40)]
    public quaternion CollisionRotation;
    [FieldOffset(56)]
    public bool Handled;
    [FieldOffset(57)]
    public bool Ignore;
    [FieldOffset(60)]
    public HitGroup HitGroup;
    [FieldOffset(64)]
    public int CastIndex;

    static HitTrigger()
    {
      Il2CppClassPointerStore<HitTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HitTrigger));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr);
      HitTrigger.NativeFieldInfoPtr_HitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (HitTime));
      HitTrigger.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (Target));
      HitTrigger.NativeFieldInfoPtr_OriginPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (OriginPosition));
      HitTrigger.NativeFieldInfoPtr_CollisionPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (CollisionPosition));
      HitTrigger.NativeFieldInfoPtr_CollisionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (CollisionRotation));
      HitTrigger.NativeFieldInfoPtr_Handled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (Handled));
      HitTrigger.NativeFieldInfoPtr_Ignore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (Ignore));
      HitTrigger.NativeFieldInfoPtr_HitGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (HitGroup));
      HitTrigger.NativeFieldInfoPtr_CastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, nameof (CastIndex));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitTrigger>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
