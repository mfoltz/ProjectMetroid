// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ProfessorProjectileOnGameplayEvent
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_ProfessorProjectileOnGameplayEvent : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectileComponentAlternate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1178065, XrefRangeEnd = 1178082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_ProfessorProjectileOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ProfessorProjectileOnGameplayEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ProfessorProjectileOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ProfessorProjectileOnGameplayEvent()
    {
      Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ProfessorProjectileOnGameplayEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr);
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_ProjectileComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (ProjectileComponent));
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_ProjectileComponentAlternate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (ProjectileComponentAlternate));
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (Count));
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (Angle));
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_RandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (RandomOffset));
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (IndividualRandom));
      Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (SpellMods));
      Script_ProfessorProjectileOnGameplayEvent.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, 100663678);
      Script_ProfessorProjectileOnGameplayEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, 100663679);
    }

    public Script_ProfessorProjectileOnGameplayEvent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent ProjectileComponent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_ProjectileComponent));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_ProjectileComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent ProjectileComponentAlternate
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_ProjectileComponentAlternate));
        return pointer == System.IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_ProjectileComponentAlternate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Count
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_Count));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_Count)) = value;
      }
    }

    public unsafe float Angle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_Angle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_Angle)) = value;
      }
    }

    public unsafe float RandomOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_RandomOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_RandomOffset)) = value;
      }
    }

    public unsafe float IndividualRandom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_IndividualRandom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_IndividualRandom)) = value;
      }
    }

    public Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_SpellMods);
        return new Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;
      private static readonly System.IntPtr NativeFieldInfoPtr_Angle;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr);
        Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, nameof (Count));
        Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, nameof (Angle));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Count
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_Count));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_Count), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Angle
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_Angle));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorProjectileOnGameplayEvent.SpellModsAuthoring.NativeFieldInfoPtr_Angle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_SpawnProjectileFan_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177973, XrefRangeEnd = 1178065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void SpawnProjectileFan(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref GameplayEvent gameplayEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref gameplayEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ProfessorProjectileOnGameplayEvent.Server.NativeMethodInfoPtr_SpawnProjectileFan_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ProfessorProjectileOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.Server>.NativeClassPtr);
        Script_ProfessorProjectileOnGameplayEvent.Server.NativeMethodInfoPtr_SpawnProjectileFan_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_GameplayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.Server>.NativeClassPtr, 100663680);
        Script_ProfessorProjectileOnGameplayEvent.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorProjectileOnGameplayEvent.Server>.NativeClassPtr, 100663681);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
