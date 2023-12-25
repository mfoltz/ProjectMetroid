// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_UpdateBuffTargetSpawnPosition
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
  public class Script_UpdateBuffTargetSpawnPosition : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_When;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175983, XrefRangeEnd = 1175986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_UpdateBuffTargetSpawnPosition.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_UpdateBuffTargetSpawnPosition()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_UpdateBuffTargetSpawnPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_UpdateBuffTargetSpawnPosition()
    {
      Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_UpdateBuffTargetSpawnPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr);
      Script_UpdateBuffTargetSpawnPosition.NativeFieldInfoPtr_When = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr, nameof (When));
      Script_UpdateBuffTargetSpawnPosition.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr, 100663493);
      Script_UpdateBuffTargetSpawnPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr, 100663494);
    }

    public Script_UpdateBuffTargetSpawnPosition(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UpdateBuffTargetSpawnPositionWhen When
    {
      get
      {
        return *(UpdateBuffTargetSpawnPositionWhen*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UpdateBuffTargetSpawnPosition.NativeFieldInfoPtr_When));
      }
      [param: In] set
      {
        *(UpdateBuffTargetSpawnPositionWhen*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_UpdateBuffTargetSpawnPosition.NativeFieldInfoPtr_When)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_Execute_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_UpdateBuffTargetSpawnPositionWhen_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175967, XrefRangeEnd = 1175968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175968, XrefRangeEnd = 1175969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1175981, RefRangeEnd = 1175983, XrefRangeStart = 1175969, XrefRangeEnd = 1175981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Execute(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        UpdateBuffTargetSpawnPositionWhen when)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &when;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr_Execute_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_UpdateBuffTargetSpawnPositionWhen_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr);
        Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr, 100663495);
        Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr, 100663496);
        Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr_Execute_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_UpdateBuffTargetSpawnPositionWhen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr, 100663497);
        Script_UpdateBuffTargetSpawnPosition.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_UpdateBuffTargetSpawnPosition.Server>.NativeClassPtr, 100663498);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
