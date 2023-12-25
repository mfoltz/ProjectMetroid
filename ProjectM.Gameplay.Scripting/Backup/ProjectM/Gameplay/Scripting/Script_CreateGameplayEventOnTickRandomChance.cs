// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnTickRandomChance
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Scripting;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_CreateGameplayEventOnTickRandomChance : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_EventTriggerChance;
    private static readonly IntPtr NativeFieldInfoPtr_EventTriggerChanceIncreasePerTry;
    private static readonly IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly IntPtr NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<GameplayEventIdSource> GameplayEventIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177087, XrefRangeEnd = 1177090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnTickRandomChance.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IEnumerable<GameplayEventIdSource>) null : new IEnumerable<GameplayEventIdSource>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177090, XrefRangeEnd = 1177094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_CreateGameplayEventOnTickRandomChance.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177094, XrefRangeEnd = 1177095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_CreateGameplayEventOnTickRandomChance()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnTickRandomChance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_CreateGameplayEventOnTickRandomChance()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnTickRandomChance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr);
      Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_EventTriggerChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, nameof (EventTriggerChance));
      Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_EventTriggerChanceIncreasePerTry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, nameof (EventTriggerChanceIncreasePerTry));
      Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, nameof (GameplayEventId));
      Script_CreateGameplayEventOnTickRandomChance.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, 100663594);
      Script_CreateGameplayEventOnTickRandomChance.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, 100663595);
      Script_CreateGameplayEventOnTickRandomChance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, 100663596);
    }

    public Script_CreateGameplayEventOnTickRandomChance(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float EventTriggerChance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_EventTriggerChance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_EventTriggerChance)) = value;
      }
    }

    public unsafe float EventTriggerChanceIncreasePerTry
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_EventTriggerChanceIncreasePerTry));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_EventTriggerChanceIncreasePerTry)) = value;
      }
    }

    public GameplayEventIdSource GameplayEventId
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_GameplayEventId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnTickRandomChance.NativeFieldInfoPtr_GameplayEventId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnTickRandomChance.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1177069, XrefRangeEnd = 1177087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnTick(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnTickRandomChance.Server.NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnTickRandomChance.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance.Server>.NativeClassPtr);
        Script_CreateGameplayEventOnTickRandomChance.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance.Server>.NativeClassPtr, 100663597);
        Script_CreateGameplayEventOnTickRandomChance.Server.NativeMethodInfoPtr_OnTick_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance.Server>.NativeClassPtr, 100663598);
        Script_CreateGameplayEventOnTickRandomChance.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnTickRandomChance.Server>.NativeClassPtr, 100663599);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
