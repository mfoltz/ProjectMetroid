// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ApplyBuffOnAllWithBuff_Cast
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
  public class Script_ApplyBuffOnAllWithBuff_Cast : GameplayScriptBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_HitFilter;
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_BuffRequired;
    private static readonly IntPtr NativeFieldInfoPtr_BuffToApply;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176661, XrefRangeEnd = 1176666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Script_ApplyBuffOnAllWithBuff_Cast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176666, XrefRangeEnd = 1176667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Script_ApplyBuffOnAllWithBuff_Cast()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Script_ApplyBuffOnAllWithBuff_Cast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Script_ApplyBuffOnAllWithBuff_Cast()
    {
      Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ApplyBuffOnAllWithBuff_Cast));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr);
      Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, nameof (HitFilter));
      Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, nameof (Radius));
      Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_BuffRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, nameof (BuffRequired));
      Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_BuffToApply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, nameof (BuffToApply));
      Script_ApplyBuffOnAllWithBuff_Cast.NativeMethodInfoPtr_Convert_Protected_Virtual_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, 100663570);
      Script_ApplyBuffOnAllWithBuff_Cast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, 100663571);
    }

    public Script_ApplyBuffOnAllWithBuff_Cast(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HitFilter HitFilter
    {
      get
      {
        return *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_HitFilter));
      }
      [param: In] set
      {
        *(HitFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_HitFilter)) = value;
      }
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe PrefabGuidComponent BuffRequired
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_BuffRequired));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_BuffRequired), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PrefabGuidComponent BuffToApply
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_BuffToApply));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Script_ApplyBuffOnAllWithBuff_Cast.NativeFieldInfoPtr_BuffToApply), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class Server : ServerScript
    {
      private static readonly IntPtr NativeMethodInfoPtr_OnCastEnd_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176649, XrefRangeEnd = 1176661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void OnCastEnd(
        ref ServerGameManager game,
        [In] ref SelfServer self,
        [In] ref AbilityCastEndedData data)
      {
        IntPtr* numPtr = stackalloc IntPtr[3];
        numPtr[0] = (IntPtr) ref game;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref self;
        *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref data;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ApplyBuffOnAllWithBuff_Cast.Server.NativeMethodInfoPtr_OnCastEnd_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0, IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1696)]
      [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Server()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast.Server>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Script_ApplyBuffOnAllWithBuff_Cast.Server.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Server()
      {
        Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast.Server>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast>.NativeClassPtr, nameof (Server));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast.Server>.NativeClassPtr);
        Script_ApplyBuffOnAllWithBuff_Cast.Server.NativeMethodInfoPtr_OnCastEnd_Protected_Static_Void_byref_ServerGameManager_byref_SelfServer_byref_AbilityCastEndedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast.Server>.NativeClassPtr, 100663572);
        Script_ApplyBuffOnAllWithBuff_Cast.Server.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Script_ApplyBuffOnAllWithBuff_Cast.Server>.NativeClassPtr, 100663573);
      }

      public Server(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
