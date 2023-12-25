﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ProfessorOverloadOrb
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
  public class Script_ProfessorOverloadOrb : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_OrbBuff;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184824, XrefRangeEnd = 1184828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_ProfessorOverloadOrb.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ProfessorOverloadOrb()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ProfessorOverloadOrb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ProfessorOverloadOrb()
    {
      Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ProfessorOverloadOrb));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr);
      Script_ProfessorOverloadOrb.NativeFieldInfoPtr_OrbBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr, nameof (OrbBuff));
      Script_ProfessorOverloadOrb.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr, 100664390);
      Script_ProfessorOverloadOrb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr, 100664391);
    }

    public Script_ProfessorOverloadOrb(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<PrefabGuidComponent> OrbBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorOverloadOrb.NativeFieldInfoPtr_OrbBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<PrefabGuidComponent>) null : new WeakAssetReference<PrefabGuidComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ProfessorOverloadOrb.NativeFieldInfoPtr_OrbBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184785, XrefRangeEnd = 1184824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ProfessorOverloadOrb.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ProfessorOverloadOrb.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ProfessorOverloadOrb.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_ProfessorOverloadOrb.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ProfessorOverloadOrb>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProfessorOverloadOrb.Server>.NativeClassPtr);
        Script_ProfessorOverloadOrb.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorOverloadOrb.Server>.NativeClassPtr, 100664392);
        Script_ProfessorOverloadOrb.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ProfessorOverloadOrb.Server>.NativeClassPtr, 100664393);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
