// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_TriggerCooldownOnSpawn
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_TriggerCooldownOnSpawn : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FetchAbilityBaseCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_CustomCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_TriggerAbility;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175963, XrefRangeEnd = 1175967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_TriggerCooldownOnSpawn.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_TriggerCooldownOnSpawn()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_TriggerCooldownOnSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_TriggerCooldownOnSpawn()
    {
      Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_TriggerCooldownOnSpawn));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr);
      Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_FetchAbilityBaseCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr, nameof (FetchAbilityBaseCooldown));
      Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_CustomCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr, nameof (CustomCooldown));
      Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_TriggerAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr, nameof (TriggerAbility));
      Script_TriggerCooldownOnSpawn.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr, 100663489);
      Script_TriggerCooldownOnSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr, 100663490);
    }

    public Script_TriggerCooldownOnSpawn(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool FetchAbilityBaseCooldown
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_FetchAbilityBaseCooldown));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_FetchAbilityBaseCooldown)) = value;
      }
    }

    public unsafe float CustomCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_CustomCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_CustomCooldown)) = value;
      }
    }

    public unsafe PrefabGuidComponent TriggerAbility
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_TriggerAbility));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_TriggerCooldownOnSpawn.NativeFieldInfoPtr_TriggerAbility), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175954, XrefRangeEnd = 1175963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void AbilityCastStarted(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastStartedData data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_TriggerCooldownOnSpawn.Server.NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_TriggerCooldownOnSpawn.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn.Server>.NativeClassPtr);
        Script_TriggerCooldownOnSpawn.Server.NativeMethodInfoPtr_AbilityCastStarted_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastStartedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn.Server>.NativeClassPtr, 100663491);
        Script_TriggerCooldownOnSpawn.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_TriggerCooldownOnSpawn.Server>.NativeClassPtr, 100663492);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
