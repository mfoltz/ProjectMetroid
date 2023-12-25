﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_GarlicAreaLeaveZoneDebuff
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
  public class Script_GarlicAreaLeaveZoneDebuff : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TimerInterval;
    private static readonly IntPtr NativeFieldInfoPtr_DynamicStacksPerTick;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184667, XrefRangeEnd = 1184670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_GarlicAreaLeaveZoneDebuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_GarlicAreaLeaveZoneDebuff()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_GarlicAreaLeaveZoneDebuff.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_GarlicAreaLeaveZoneDebuff()
    {
      Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_GarlicAreaLeaveZoneDebuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr);
      Script_GarlicAreaLeaveZoneDebuff.NativeFieldInfoPtr_TimerInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr, nameof (TimerInterval));
      Script_GarlicAreaLeaveZoneDebuff.NativeFieldInfoPtr_DynamicStacksPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr, nameof (DynamicStacksPerTick));
      Script_GarlicAreaLeaveZoneDebuff.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr, 100664371);
      Script_GarlicAreaLeaveZoneDebuff.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr, 100664372);
    }

    public Script_GarlicAreaLeaveZoneDebuff(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TimerInterval
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicAreaLeaveZoneDebuff.NativeFieldInfoPtr_TimerInterval));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicAreaLeaveZoneDebuff.NativeFieldInfoPtr_TimerInterval)) = value;
      }
    }

    public unsafe float DynamicStacksPerTick
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicAreaLeaveZoneDebuff.NativeFieldInfoPtr_DynamicStacksPerTick));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_GarlicAreaLeaveZoneDebuff.NativeFieldInfoPtr_DynamicStacksPerTick)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184628, XrefRangeEnd = 1184637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184637, XrefRangeEnd = 1184667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr);
        Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr, 100664373);
        Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr, 100664374);
        Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr, 100664375);
        Script_GarlicAreaLeaveZoneDebuff.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_GarlicAreaLeaveZoneDebuff.Server>.NativeClassPtr, 100664376);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
