// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackEvent
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
  public struct KnockbackEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Creator;
    [FieldOffset(0)]
    public KnockbackPower KnockbackPower;
    [FieldOffset(180)]
    public float3 Direction;
    [FieldOffset(192)]
    public float Duration;
    [FieldOffset(196)]
    public float Range;
    [FieldOffset(200)]
    public Entity Target;
    [FieldOffset(208)]
    public Entity Owner;
    [FieldOffset(216)]
    public Entity Creator;

    static KnockbackEvent()
    {
      Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr);
      KnockbackEvent.NativeFieldInfoPtr_KnockbackPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (KnockbackPower));
      KnockbackEvent.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (Direction));
      KnockbackEvent.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (Duration));
      KnockbackEvent.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (Range));
      KnockbackEvent.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (Target));
      KnockbackEvent.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (Owner));
      KnockbackEvent.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, nameof (Creator));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
