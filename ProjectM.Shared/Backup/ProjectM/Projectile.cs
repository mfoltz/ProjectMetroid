// Decompiled with JetBrains decompiler
// Type: ProjectM.Projectile
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Projectile
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelToMouseCursorLengthOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelToMouseCursor;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecalculateLifetimeBasedOnTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideLifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayLifeTime;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float3 StartPosition;
    [FieldOffset(12)]
    public float3 EndPosition;
    [FieldOffset(24)]
    public float Range;
    [FieldOffset(28)]
    public float Speed;
    [FieldOffset(32)]
    public float TravelToMouseCursorLengthOffset;
    [FieldOffset(36)]
    public float MinRange;
    [FieldOffset(40)]
    public bool TravelToMouseCursor;
    [FieldOffset(41)]
    public bool RecalculateLifetimeBasedOnTarget;
    [FieldOffset(44)]
    public float OverrideLifeTime;
    [FieldOffset(48)]
    public float DelayLifeTime;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726768, RefRangeEnd = 726769, XrefRangeStart = 726766, XrefRangeEnd = 726768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Projectile.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Projectile()
    {
      Il2CppClassPointerStore<Projectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Projectile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Projectile>.NativeClassPtr);
      Projectile.NativeFieldInfoPtr_StartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (StartPosition));
      Projectile.NativeFieldInfoPtr_EndPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (EndPosition));
      Projectile.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (Range));
      Projectile.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (Speed));
      Projectile.NativeFieldInfoPtr_TravelToMouseCursorLengthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (TravelToMouseCursorLengthOffset));
      Projectile.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (MinRange));
      Projectile.NativeFieldInfoPtr_TravelToMouseCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (TravelToMouseCursor));
      Projectile.NativeFieldInfoPtr_RecalculateLifetimeBasedOnTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (RecalculateLifetimeBasedOnTarget));
      Projectile.NativeFieldInfoPtr_OverrideLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (OverrideLifeTime));
      Projectile.NativeFieldInfoPtr_DelayLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Projectile>.NativeClassPtr, nameof (DelayLifeTime));
      Projectile.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Projectile>.NativeClassPtr, 100664264);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Projectile>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
