// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Buff_HealthThreshold
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
  public class Script_Buff_HealthThreshold : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_BuffPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_HealthFactor1;
    private static readonly IntPtr NativeFieldInfoPtr_HealthFactor2;
    private static readonly IntPtr NativeFieldInfoPtr_HealthFactor3;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187750, XrefRangeEnd = 1187754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_Buff_HealthThreshold.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_Buff_HealthThreshold()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealthThreshold.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_Buff_HealthThreshold()
    {
      Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Buff_HealthThreshold));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr);
      Script_Buff_HealthThreshold.NativeFieldInfoPtr_BuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, nameof (BuffPrefab));
      Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, nameof (HealthFactor1));
      Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, nameof (HealthFactor2));
      Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, nameof (HealthFactor3));
      Script_Buff_HealthThreshold.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, 100664671);
      Script_Buff_HealthThreshold.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, 100664672);
    }

    public Script_Buff_HealthThreshold(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent BuffPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_BuffPrefab));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_BuffPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float HealthFactor1
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor1));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor1)) = value;
      }
    }

    public unsafe float HealthFactor2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor2)) = value;
      }
    }

    public unsafe float HealthFactor3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_Buff_HealthThreshold.NativeFieldInfoPtr_HealthFactor3)) = value;
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1187737, XrefRangeEnd = 1187750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Update(ref ServerGameManager game, [In] ref SelfServer self)
      {
        IntPtr* numPtr = stackalloc IntPtr[2];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealthThreshold.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_Buff_HealthThreshold.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_Buff_HealthThreshold.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_Buff_HealthThreshold.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_Buff_HealthThreshold>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Buff_HealthThreshold.Server>.NativeClassPtr);
        Script_Buff_HealthThreshold.Server.NativeMethodInfoPtr_Update_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealthThreshold.Server>.NativeClassPtr, 100664673);
        Script_Buff_HealthThreshold.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_Buff_HealthThreshold.Server>.NativeClassPtr, 100664674);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
