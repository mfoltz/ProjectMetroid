// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_EmpowerDamageDealtByType
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_Buff_EmpowerDamageDealtByType : GameplayScriptBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactorPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_Buff_EmpowerDamageDealtByType.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182722, XrefRangeEnd = 1182729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_EmpowerDamageDealtByType.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_EmpowerDamageDealtByType()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_EmpowerDamageDealtByType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_EmpowerDamageDealtByType()
    {
      Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_EmpowerDamageDealtByType));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr);
      Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, nameof (DamageFactor));
      Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageFactorPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, nameof (DamageFactorPerStack));
      Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, nameof (DamageType));
      Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, nameof (SpellMods));
      Script_Buff_EmpowerDamageDealtByType.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, 100664171);
      Script_Buff_EmpowerDamageDealtByType.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, 100664172);
      Script_Buff_EmpowerDamageDealtByType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, 100664173);
    }

    public Script_Buff_EmpowerDamageDealtByType(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float DamageFactor
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageFactor));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageFactor)) = value;
      }
    }

    public unsafe float DamageFactorPerStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageFactorPerStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageFactorPerStack)) = value;
      }
    }

    public unsafe MainDamageType DamageType
    {
      get
      {
        return *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageType));
      }
      [param: In] set
      {
        *(MainDamageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_DamageType)) = value;
      }
    }

    public Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_SpellMods);
        return new Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactor;
      private static readonly System.IntPtr NativeFieldInfoPtr_DamageFactorPerStack;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr);
        Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring.NativeFieldInfoPtr_DamageFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr, nameof (DamageFactor));
        Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring.NativeFieldInfoPtr_DamageFactorPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr, nameof (DamageFactorPerStack));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> DamageFactor
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring.NativeFieldInfoPtr_DamageFactor));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring.NativeFieldInfoPtr_DamageFactor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> DamageFactorPerStack
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring.NativeFieldInfoPtr_DamageFactorPerStack));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_EmpowerDamageDealtByType.SpellModsAuthoring.NativeFieldInfoPtr_DamageFactorPerStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class Server : ServerScript
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182693, XrefRangeEnd = 1182711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_EmpowerDamageDealtByType.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182711, XrefRangeEnd = 1182722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnDamageDealt(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) ref game;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref self;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref statChangeEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_EmpowerDamageDealtByType.Server.NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.Server>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_EmpowerDamageDealtByType.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.Server>.NativeClassPtr);
        Script_Buff_EmpowerDamageDealtByType.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.Server>.NativeClassPtr, 100664174);
        Script_Buff_EmpowerDamageDealtByType.Server.NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.Server>.NativeClassPtr, 100664175);
        Script_Buff_EmpowerDamageDealtByType.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_EmpowerDamageDealtByType.Server>.NativeClassPtr, 100664176);
      }

      public Server(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
