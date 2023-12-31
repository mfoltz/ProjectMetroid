// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelBuffSpawn
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TravelBuffSpawn
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetRangeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffsetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelTargetMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetStartPositionFromBuffTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScaleDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreAllCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimYOffset;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float TargetRangeOffset;
    [FieldOffset(4)]
    public float MinRange;
    [FieldOffset(8)]
    public float MaxRange;
    [FieldOffset(12)]
    public float RandomOffsetRadius;
    [FieldOffset(16)]
    public float MinDuration;
    [FieldOffset(20)]
    public float MaxDuration;
    [FieldOffset(24)]
    public TravelTargetMode TravelTargetMode;
    [FieldOffset(28)]
    public bool GetStartPositionFromBuffTarget;
    [FieldOffset(29)]
    public bool ScaleDuration;
    [FieldOffset(30)]
    public bool IgnoreAllCollision;
    [FieldOffset(32)]
    public float AimYOffset;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727113, RefRangeEnd = 727114, XrefRangeStart = 727109, XrefRangeEnd = 727113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelBuffSpawn.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TravelBuffSpawn()
    {
      Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TravelBuffSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr);
      TravelBuffSpawn.NativeFieldInfoPtr_TargetRangeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (TargetRangeOffset));
      TravelBuffSpawn.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (MinRange));
      TravelBuffSpawn.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (MaxRange));
      TravelBuffSpawn.NativeFieldInfoPtr_RandomOffsetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (RandomOffsetRadius));
      TravelBuffSpawn.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (MinDuration));
      TravelBuffSpawn.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (MaxDuration));
      TravelBuffSpawn.NativeFieldInfoPtr_TravelTargetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (TravelTargetMode));
      TravelBuffSpawn.NativeFieldInfoPtr_GetStartPositionFromBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (GetStartPositionFromBuffTarget));
      TravelBuffSpawn.NativeFieldInfoPtr_ScaleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (ScaleDuration));
      TravelBuffSpawn.NativeFieldInfoPtr_IgnoreAllCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (IgnoreAllCollision));
      TravelBuffSpawn.NativeFieldInfoPtr_AimYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, nameof (AimYOffset));
      TravelBuffSpawn.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, 100664307);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelBuffSpawn>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
