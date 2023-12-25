// Decompiled with JetBrains decompiler
// Type: ProjectM.HitColliderCast
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Physics;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HitColliderCast
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Shape;
    private static readonly System.IntPtr NativeFieldInfoPtr_AfterDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TerrainColliderModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrioritySettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionCheckType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryFilterFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_TriggerType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrimaryTargets_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryTargets_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContiniousCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeTerrain;
    private static readonly System.IntPtr NativeFieldInfoPtr_CanHitThroughBlockSpellCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreImmaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_Handled;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalTargets_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0;
    [FieldOffset(0)]
    public float3 Offset;
    [FieldOffset(12)]
    public TriggerShape Shape;
    [FieldOffset(28)]
    public float AfterDuration;
    [FieldOffset(32)]
    public float TerrainColliderModifier;
    [FieldOffset(36)]
    public AoEFilterSettings PrioritySettings;
    [FieldOffset(56)]
    public CollisionTrigger CollisionCheckType;
    [FieldOffset(60)]
    public CollisionFilterFlags PrimaryFilterFlags;
    [FieldOffset(64)]
    public CollisionTrigger TriggerType;
    [FieldOffset(68)]
    public int PrimaryTargets_Count;
    [FieldOffset(72)]
    public int SecondaryTargets_Count;
    [FieldOffset(76)]
    public bool ContiniousCollision;
    [FieldOffset(77)]
    public bool IncludeTerrain;
    [FieldOffset(78)]
    public bool CanHitThroughBlockSpellCollision;
    [FieldOffset(79)]
    public bool IgnoreImmaterial;
    [FieldOffset(80)]
    public bool Handled;

    public unsafe int TotalTargets
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitColliderCast.NativeMethodInfoPtr_get_TotalTargets_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011063, XrefRangeEnd = 1011064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ApplyArithmetic(SpellModArithmetic spellMod, float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &spellMod;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitColliderCast.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HitColliderCast()
    {
      Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (HitColliderCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr);
      HitColliderCast.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (Offset));
      HitColliderCast.NativeFieldInfoPtr_Shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (Shape));
      HitColliderCast.NativeFieldInfoPtr_AfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (AfterDuration));
      HitColliderCast.NativeFieldInfoPtr_TerrainColliderModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (TerrainColliderModifier));
      HitColliderCast.NativeFieldInfoPtr_PrioritySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (PrioritySettings));
      HitColliderCast.NativeFieldInfoPtr_CollisionCheckType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (CollisionCheckType));
      HitColliderCast.NativeFieldInfoPtr_PrimaryFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (PrimaryFilterFlags));
      HitColliderCast.NativeFieldInfoPtr_TriggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (TriggerType));
      HitColliderCast.NativeFieldInfoPtr_PrimaryTargets_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (PrimaryTargets_Count));
      HitColliderCast.NativeFieldInfoPtr_SecondaryTargets_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (SecondaryTargets_Count));
      HitColliderCast.NativeFieldInfoPtr_ContiniousCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (ContiniousCollision));
      HitColliderCast.NativeFieldInfoPtr_IncludeTerrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (IncludeTerrain));
      HitColliderCast.NativeFieldInfoPtr_CanHitThroughBlockSpellCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (CanHitThroughBlockSpellCollision));
      HitColliderCast.NativeFieldInfoPtr_IgnoreImmaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (IgnoreImmaterial));
      HitColliderCast.NativeFieldInfoPtr_Handled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (Handled));
      HitColliderCast.NativeMethodInfoPtr_get_TotalTargets_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, 100678660);
      HitColliderCast.NativeMethodInfoPtr_ApplyArithmetic_Public_Virtual_Final_New_Void_SpellModArithmetic_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, 100678661);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, (System.IntPtr) ref this));
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CollisionCastOnSpawn
    {
      static CollisionCastOnSpawn()
      {
        Il2CppClassPointerStore<HitColliderCast.CollisionCastOnSpawn>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (CollisionCastOnSpawn));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCast.CollisionCastOnSpawn>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitColliderCast.CollisionCastOnSpawn>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CollisionCastOnUpdate
    {
      static CollisionCastOnUpdate()
      {
        Il2CppClassPointerStore<HitColliderCast.CollisionCastOnUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (CollisionCastOnUpdate));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCast.CollisionCastOnUpdate>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitColliderCast.CollisionCastOnUpdate>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CollisionCastOnDestroy
    {
      static CollisionCastOnDestroy()
      {
        Il2CppClassPointerStore<HitColliderCast.CollisionCastOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitColliderCast>.NativeClassPtr, nameof (CollisionCastOnDestroy));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitColliderCast.CollisionCastOnDestroy>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitColliderCast.CollisionCastOnDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
