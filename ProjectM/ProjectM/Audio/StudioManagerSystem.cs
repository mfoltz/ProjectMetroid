// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioManagerSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Audio
{
  public class StudioManagerSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__DebugOverlay;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsOverlayEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayMusic;
    private static readonly System.IntPtr NativeFieldInfoPtr_AsynchronousLoading;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StudioManager_Public_get_StudioManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StudioManager_Private_set_Void_StudioManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitSoftwareFormat_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeInitialization_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDriver_Public_Boolean_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrintableSoundState_Public_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe StudioManager StudioManager
    {
      [CallerCount(24), CachedScanResults(RefRangeStart = 1144182, RefRangeEnd = 1144206, XrefRangeStart = 1144181, XrefRangeEnd = 1144182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr_get_StudioManager_Public_get_StudioManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StudioManager) null : new StudioManager(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr_set_StudioManager_Private_set_Void_StudioManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144206, XrefRangeEnd = 1144227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioManagerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144227, XrefRangeEnd = 1144268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitSoftwareFormat()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr_InitSoftwareFormat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1144322, RefRangeEnd = 1144334, XrefRangeStart = 1144268, XrefRangeEnd = 1144322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FinalizeInitialization()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr_FinalizeInitialization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1144350, RefRangeEnd = 1144352, XrefRangeStart = 1144334, XrefRangeEnd = 1144350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool SetDriver(Il2CppSystem.Guid setDriverGuid)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &setDriverGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr_SetDriver_Public_Boolean_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144352, XrefRangeEnd = 1144362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioManagerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144362, XrefRangeEnd = 1144390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioManagerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1144460, RefRangeEnd = 1144461, XrefRangeStart = 1144390, XrefRangeEnd = 1144460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string GetPrintableSoundState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr_GetPrintableSoundState_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1144461, XrefRangeEnd = 1144462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StudioManagerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioManagerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioManagerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StudioManagerSystem()
    {
      Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioManagerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr);
      StudioManagerSystem.NativeFieldInfoPtr__StudioManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, nameof (_StudioManager));
      StudioManagerSystem.NativeFieldInfoPtr__DebugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, nameof (_DebugOverlay));
      StudioManagerSystem.NativeFieldInfoPtr__IsOverlayEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, nameof (_IsOverlayEnabled));
      StudioManagerSystem.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, nameof (_Initialized));
      StudioManagerSystem.NativeFieldInfoPtr_PlayMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, nameof (PlayMusic));
      StudioManagerSystem.NativeFieldInfoPtr_AsynchronousLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, nameof (AsynchronousLoading));
      StudioManagerSystem.NativeMethodInfoPtr_get_StudioManager_Public_get_StudioManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690580);
      StudioManagerSystem.NativeMethodInfoPtr_set_StudioManager_Private_set_Void_StudioManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690581);
      StudioManagerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690582);
      StudioManagerSystem.NativeMethodInfoPtr_InitSoftwareFormat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690583);
      StudioManagerSystem.NativeMethodInfoPtr_FinalizeInitialization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690584);
      StudioManagerSystem.NativeMethodInfoPtr_SetDriver_Public_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690585);
      StudioManagerSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690586);
      StudioManagerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690587);
      StudioManagerSystem.NativeMethodInfoPtr_GetPrintableSoundState_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690588);
      StudioManagerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690589);
      StudioManagerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioManagerSystem>.NativeClassPtr, 100690590);
    }

    public StudioManagerSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StudioManager _StudioManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__StudioManager));
        return pointer == System.IntPtr.Zero ? (StudioManager) null : new StudioManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__StudioManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FmodDebugOverlayMonoBehaviour _DebugOverlay
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__DebugOverlay));
        return pointer == System.IntPtr.Zero ? (FmodDebugOverlayMonoBehaviour) null : new FmodDebugOverlayMonoBehaviour(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__DebugOverlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsOverlayEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__IsOverlayEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__IsOverlayEnabled)) = value;
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr__Initialized)) = value;
      }
    }

    public unsafe bool PlayMusic
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr_PlayMusic));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr_PlayMusic)) = value;
      }
    }

    public unsafe bool AsynchronousLoading
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr_AsynchronousLoading));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioManagerSystem.NativeFieldInfoPtr_AsynchronousLoading)) = value;
      }
    }
  }
}
