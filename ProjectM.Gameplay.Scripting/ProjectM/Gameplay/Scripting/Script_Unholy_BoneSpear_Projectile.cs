// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Unholy_BoneSpear_Projectile
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Unholy_BoneSpear_Projectile : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpellDamage;
    private static readonly IntPtr NativeFieldInfoPtr_ConsumeRadius;
    private static readonly IntPtr NativeFieldInfoPtr_ExplosionRadius;
    private static readonly IntPtr NativeFieldInfoPtr_UnitType;
    private static readonly IntPtr NativeFieldInfoPtr_BuffType;
    private static readonly IntPtr NativeFieldInfoPtr_ConsumeHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_ExplosionHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_ExplosionSequence;
    private static readonly IntPtr NativeFieldInfoPtr_IsCharged;
    private static readonly IntPtr NativeFieldInfoPtr_ChargedBuffType;
    private static readonly IntPtr NativeFieldInfoPtr_BuffDuration;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179116, XrefRangeEnd = 1179123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Unholy_BoneSpear_Projectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179123, XrefRangeEnd = 1179124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Unholy_BoneSpear_Projectile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Unholy_BoneSpear_Projectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Unholy_BoneSpear_Projectile()
    {
      Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Unholy_BoneSpear_Projectile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr);
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_SpellDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (SpellDamage));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ConsumeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (ConsumeRadius));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (ExplosionRadius));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_UnitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (UnitType));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_BuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (BuffType));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ConsumeHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (ConsumeHitFilter));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (ExplosionHitFilter));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (ExplosionSequence));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_IsCharged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (IsCharged));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ChargedBuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (ChargedBuffType));
      Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_BuffDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (BuffDuration));
      Script_Unholy_BoneSpear_Projectile.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, 100663784);
      Script_Unholy_BoneSpear_Projectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, 100663785);
    }

    public Script_Unholy_BoneSpear_Projectile(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SpellDamage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_SpellDamage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_SpellDamage)) = value;
      }
    }

    public unsafe float ConsumeRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ConsumeRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ConsumeRadius)) = value;
      }
    }

    public unsafe float ExplosionRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionRadius)) = value;
      }
    }

    public unsafe PrefabGuidComponent UnitType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_UnitType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_UnitType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent BuffType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_BuffType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_BuffType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HitFilter ConsumeHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ConsumeHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ConsumeHitFilter)) = value;
      }
    }

    public unsafe HitFilter ExplosionHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionHitFilter)) = value;
      }
    }

    public unsafe SequenceField ExplosionSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ExplosionSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsCharged
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_IsCharged));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_IsCharged)) = value;
      }
    }

    public unsafe PrefabGuidComponent ChargedBuffType
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ChargedBuffType));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_ChargedBuffType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float BuffDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_BuffDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Unholy_BoneSpear_Projectile.NativeFieldInfoPtr_BuffDuration)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnTrigger_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179054, XrefRangeEnd = 1179064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Unholy_BoneSpear_Projectile.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179064, XrefRangeEnd = 1179116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnTrigger(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        NativeArray<HitResult> hits)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &hits;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Unholy_BoneSpear_Projectile.Server.NativeMethodInfoPtr_OnTrigger_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Unholy_BoneSpear_Projectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile.Server>.NativeClassPtr);
        Script_Unholy_BoneSpear_Projectile.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile.Server>.NativeClassPtr, 100663786);
        Script_Unholy_BoneSpear_Projectile.Server.NativeMethodInfoPtr_OnTrigger_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_NativeArray_1_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile.Server>.NativeClassPtr, 100663787);
        Script_Unholy_BoneSpear_Projectile.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Unholy_BoneSpear_Projectile.Server>.NativeClassPtr, 100663788);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
