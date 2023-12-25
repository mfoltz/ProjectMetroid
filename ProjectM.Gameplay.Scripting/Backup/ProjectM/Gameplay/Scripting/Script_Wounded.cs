// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Wounded
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
  public class Script_Wounded : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176137, XrefRangeEnd = 1176140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Wounded.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176140, XrefRangeEnd = 1176147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Wounded.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Wounded()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Wounded.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Wounded()
    {
      Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Wounded));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr);
      Script_Wounded.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr, 100663499);
      Script_Wounded.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr, 100663500);
      Script_Wounded.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr, 100663501);
    }

    public Script_Wounded(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_AlterKnockbackResistance_Private_Static_Void_ServerGameManager_SelfServer_Buff_Script_Wounded_DataShared_0;
      private static readonly IntPtr NativeMethodInfoPtr_OnDamageTaken_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0;
      private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_RemoveKnockbackModification_Private_Static_Void_byref_ServerGameManager_SelfServer_byref_Script_Wounded_DataShared_Buff_0;
      private static readonly IntPtr NativeMethodInfoPtr_TriggerWounded_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175986, XrefRangeEnd = 1176012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Spawn(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176012, XrefRangeEnd = 1176028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void AlterKnockbackResistance(
        ServerGameManager game,
        SelfServer self,
        Buff buff,
        Script_Wounded_DataShared dataShared)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) &game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &buff;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &dataShared;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr_AlterKnockbackResistance_Private_Static_Void_ServerGameManager_SelfServer_Buff_Script_Wounded_DataShared_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176028, XrefRangeEnd = 1176049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnDamageTaken(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        ref StatChangeEvent statChangeEvent)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref statChangeEvent;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr_OnDamageTaken_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176049, XrefRangeEnd = 1176061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Destroy(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1176071, RefRangeEnd = 1176073, XrefRangeStart = 1176061, XrefRangeEnd = 1176071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RemoveKnockbackModification(
        ref ServerGameManager game,
        SelfServer self,
        ref Script_Wounded_DataShared dataShared,
        Buff buff)
      {
        IntPtr* numPtr = stackalloc IntPtr[4];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref dataShared;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &buff;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr_RemoveKnockbackModification_Private_Static_Void_byref_ServerGameManager_SelfServer_byref_Script_Wounded_DataShared_Buff_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1176122, RefRangeEnd = 1176123, XrefRangeStart = 1176073, XrefRangeEnd = 1176122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void TriggerWounded(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref Entity statschangeEntity)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref statschangeEntity;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr_TriggerWounded_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr);
        Script_Wounded.Server.NativeMethodInfoPtr_Spawn_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663502);
        Script_Wounded.Server.NativeMethodInfoPtr_AlterKnockbackResistance_Private_Static_Void_ServerGameManager_SelfServer_Buff_Script_Wounded_DataShared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663503);
        Script_Wounded.Server.NativeMethodInfoPtr_OnDamageTaken_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_StatChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663504);
        Script_Wounded.Server.NativeMethodInfoPtr_Destroy_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663505);
        Script_Wounded.Server.NativeMethodInfoPtr_RemoveKnockbackModification_Private_Static_Void_byref_ServerGameManager_SelfServer_byref_Script_Wounded_DataShared_Buff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663506);
        Script_Wounded.Server.NativeMethodInfoPtr_TriggerWounded_Private_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663507);
        Script_Wounded.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Server>.NativeClassPtr, 100663508);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176123, XrefRangeEnd = 1176137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Wounded.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Wounded.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_Wounded.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Wounded>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Wounded.Client>.NativeClassPtr);
        Script_Wounded.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Client>.NativeClassPtr, 100663509);
        Script_Wounded.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Wounded.Client>.NativeClassPtr, 100663510);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
