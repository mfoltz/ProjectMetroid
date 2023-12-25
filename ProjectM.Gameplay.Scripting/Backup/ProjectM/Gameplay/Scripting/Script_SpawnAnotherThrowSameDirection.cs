﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_SpawnAnotherThrowSameDirection
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
  public class Script_SpawnAnotherThrowSameDirection : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_NextThrow;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189127, XrefRangeEnd = 1189131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_SpawnAnotherThrowSameDirection.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_SpawnAnotherThrowSameDirection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_SpawnAnotherThrowSameDirection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_SpawnAnotherThrowSameDirection()
    {
      Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_SpawnAnotherThrowSameDirection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr);
      Script_SpawnAnotherThrowSameDirection.NativeFieldInfoPtr_NextThrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr, nameof (NextThrow));
      Script_SpawnAnotherThrowSameDirection.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr, 100664807);
      Script_SpawnAnotherThrowSameDirection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr, 100664808);
    }

    public Script_SpawnAnotherThrowSameDirection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent NextThrow
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnAnotherThrowSameDirection.NativeFieldInfoPtr_NextThrow));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_SpawnAnotherThrowSameDirection.NativeFieldInfoPtr_NextThrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189106, XrefRangeEnd = 1189127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpawnAnotherThrowSameDirection.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_SpawnAnotherThrowSameDirection.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection.Server>.NativeClassPtr);
        Script_SpawnAnotherThrowSameDirection.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection.Server>.NativeClassPtr, 100664809);
        Script_SpawnAnotherThrowSameDirection.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_SpawnAnotherThrowSameDirection.Server>.NativeClassPtr, 100664810);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
