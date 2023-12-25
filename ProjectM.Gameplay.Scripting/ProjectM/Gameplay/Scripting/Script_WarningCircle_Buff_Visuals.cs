// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_WarningCircle_Buff_Visuals
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Scripting;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  public class Script_WarningCircle_Buff_Visuals : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_FuseSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189488, XrefRangeEnd = 1189492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_WarningCircle_Buff_Visuals.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189492, XrefRangeEnd = 1189499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_WarningCircle_Buff_Visuals.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_WarningCircle_Buff_Visuals()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_WarningCircle_Buff_Visuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_WarningCircle_Buff_Visuals()
    {
      Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_WarningCircle_Buff_Visuals));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr);
      Script_WarningCircle_Buff_Visuals.NativeFieldInfoPtr_FuseSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr, nameof (FuseSequence));
      Script_WarningCircle_Buff_Visuals.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr, 100664840);
      Script_WarningCircle_Buff_Visuals.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr, 100664841);
      Script_WarningCircle_Buff_Visuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr, 100664842);
    }

    public Script_WarningCircle_Buff_Visuals(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceField FuseSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_WarningCircle_Buff_Visuals.NativeFieldInfoPtr_FuseSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_WarningCircle_Buff_Visuals.NativeFieldInfoPtr_FuseSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Client : ClientScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189444, XrefRangeEnd = 1189488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ClientGameManager game, [In] ref SelfClient self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_WarningCircle_Buff_Visuals.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Client()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals.Client>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_WarningCircle_Buff_Visuals.Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Client()
      {
        Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals.Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals>.NativeClassPtr, nameof (Client));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals.Client>.NativeClassPtr);
        Script_WarningCircle_Buff_Visuals.Client.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ClientGameManager_byref_SelfClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals.Client>.NativeClassPtr, 100664843);
        Script_WarningCircle_Buff_Visuals.Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_WarningCircle_Buff_Visuals.Client>.NativeClassPtr, 100664844);
      }

      public Client(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
