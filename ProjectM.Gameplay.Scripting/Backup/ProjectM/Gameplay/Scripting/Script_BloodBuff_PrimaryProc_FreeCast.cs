﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_BloodBuff_PrimaryProc_FreeCast
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
  public class Script_BloodBuff_PrimaryProc_FreeCast : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MinBonus;
    private static readonly IntPtr NativeFieldInfoPtr_MaxBonus;
    private static readonly IntPtr NativeFieldInfoPtr_FreeCastBuff;
    private static readonly IntPtr NativeFieldInfoPtr_RequiredBloodPercentage;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181087, XrefRangeEnd = 1181091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_BloodBuff_PrimaryProc_FreeCast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_BloodBuff_PrimaryProc_FreeCast()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_PrimaryProc_FreeCast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_BloodBuff_PrimaryProc_FreeCast()
    {
      Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_BloodBuff_PrimaryProc_FreeCast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr);
      Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_MinBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, nameof (MinBonus));
      Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_MaxBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, nameof (MaxBonus));
      Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_FreeCastBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, nameof (FreeCastBuff));
      Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_RequiredBloodPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, nameof (RequiredBloodPercentage));
      Script_BloodBuff_PrimaryProc_FreeCast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, 100663985);
      Script_BloodBuff_PrimaryProc_FreeCast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, 100663986);
    }

    public Script_BloodBuff_PrimaryProc_FreeCast(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_MinBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_MinBonus)) = value;
      }
    }

    public unsafe float MaxBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_MaxBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_MaxBonus)) = value;
      }
    }

    public unsafe PrefabGuidComponent FreeCastBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_FreeCastBuff));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_FreeCastBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float RequiredBloodPercentage
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_RequiredBloodPercentage));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_BloodBuff_PrimaryProc_FreeCast.NativeFieldInfoPtr_RequiredBloodPercentage)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181052, XrefRangeEnd = 1181068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_PrimaryProc_FreeCast.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181068, XrefRangeEnd = 1181087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnDamageDealt(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref statChangeEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_PrimaryProc_FreeCast.Server.NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_BloodBuff_PrimaryProc_FreeCast.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast.Server>.NativeClassPtr);
        Script_BloodBuff_PrimaryProc_FreeCast.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast.Server>.NativeClassPtr, 100663987);
        Script_BloodBuff_PrimaryProc_FreeCast.Server.NativeMethodInfoPtr_OnDamageDealt_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast.Server>.NativeClassPtr, 100663988);
        Script_BloodBuff_PrimaryProc_FreeCast.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_BloodBuff_PrimaryProc_FreeCast.Server>.NativeClassPtr, 100663989);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}