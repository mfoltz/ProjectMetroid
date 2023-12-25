// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CreateGameplayEventOnHitDetection
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
  public class Script_CreateGameplayEventOnHitDetection : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_TargetMainCategory;
    private static readonly IntPtr NativeFieldInfoPtr_TargetMaterialCategory;
    private static readonly IntPtr NativeFieldInfoPtr_MultipleHits;
    private static readonly IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly IntPtr NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<GameplayEventIdSource> GameplayEventIds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187076, XrefRangeEnd = 1187079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitDetection.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (IEnumerable<GameplayEventIdSource>) null : new IEnumerable<GameplayEventIdSource>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187079, XrefRangeEnd = 1187083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_CreateGameplayEventOnHitDetection.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_CreateGameplayEventOnHitDetection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitDetection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_CreateGameplayEventOnHitDetection()
    {
      Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CreateGameplayEventOnHitDetection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr);
      Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, nameof (TargetHitFilter));
      Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetMainCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, nameof (TargetMainCategory));
      Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetMaterialCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, nameof (TargetMaterialCategory));
      Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_MultipleHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, nameof (MultipleHits));
      Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, nameof (GameplayEventId));
      Script_CreateGameplayEventOnHitDetection.NativeMethodInfoPtr_get_GameplayEventIds_Public_Virtual_Final_New_get_IEnumerable_1_GameplayEventIdSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, 100664594);
      Script_CreateGameplayEventOnHitDetection.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, 100664595);
      Script_CreateGameplayEventOnHitDetection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, 100664596);
    }

    public Script_CreateGameplayEventOnHitDetection(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HitFilter TargetHitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetHitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetHitFilter)) = value;
      }
    }

    public unsafe MainEntityCategory TargetMainCategory
    {
      get
      {
        return *(MainEntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetMainCategory));
      }
      [param: In] set
      {
        *(MainEntityCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetMainCategory)) = value;
      }
    }

    public unsafe MaterialCategory TargetMaterialCategory
    {
      get
      {
        return *(MaterialCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetMaterialCategory));
      }
      [param: In] set
      {
        *(MaterialCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_TargetMaterialCategory)) = value;
      }
    }

    public unsafe bool MultipleHits
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_MultipleHits));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_MultipleHits)) = value;
      }
    }

    public GameplayEventIdSource GameplayEventId
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_GameplayEventId);
        return new GameplayEventIdSource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_CreateGameplayEventOnHitDetection.NativeFieldInfoPtr_GameplayEventId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameplayEventIdSource>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr_EventHitDetectionTrigger_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187019, XrefRangeEnd = 1187056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitDetection.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1187075, RefRangeEnd = 1187076, XrefRangeStart = 1187056, XrefRangeEnd = 1187075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe bool EventHitDetectionTrigger(
        ref ServerGameManager game,
        SelfServer self,
        Entity targetHit)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &targetHit;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitDetection.Server.NativeMethodInfoPtr_EventHitDetectionTrigger_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_CreateGameplayEventOnHitDetection.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection.Server>.NativeClassPtr);
        Script_CreateGameplayEventOnHitDetection.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection.Server>.NativeClassPtr, 100664597);
        Script_CreateGameplayEventOnHitDetection.Server.NativeMethodInfoPtr_EventHitDetectionTrigger_Protected_Static_Boolean_byref_ServerGameManager_SelfServer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection.Server>.NativeClassPtr, 100664598);
        Script_CreateGameplayEventOnHitDetection.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_CreateGameplayEventOnHitDetection.Server>.NativeClassPtr, 100664599);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
