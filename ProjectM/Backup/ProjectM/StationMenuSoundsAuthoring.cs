// Decompiled with JetBrains decompiler
// Type: ProjectM.StationMenuSoundsAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Fmod;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class StationMenuSoundsAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SoundMapping;
    private static readonly IntPtr NativeFieldInfoPtr_OpenSoundEvent;
    private static readonly IntPtr NativeFieldInfoPtr_CloseSoundEvent;
    private static readonly IntPtr NativeFieldInfoPtr_OpenSound;
    private static readonly IntPtr NativeFieldInfoPtr_CloseSound;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073196, XrefRangeEnd = 1073210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
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
      IL2CPP.il2cpp_runtime_invoke(StationMenuSoundsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StationMenuSoundsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StationMenuSoundsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StationMenuSoundsAuthoring()
    {
      Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StationMenuSoundsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr);
      StationMenuSoundsAuthoring.NativeFieldInfoPtr_SoundMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, nameof (SoundMapping));
      StationMenuSoundsAuthoring.NativeFieldInfoPtr_OpenSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, nameof (OpenSoundEvent));
      StationMenuSoundsAuthoring.NativeFieldInfoPtr_CloseSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, nameof (CloseSoundEvent));
      StationMenuSoundsAuthoring.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, nameof (OpenSound));
      StationMenuSoundsAuthoring.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, nameof (CloseSound));
      StationMenuSoundsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, 100684543);
      StationMenuSoundsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationMenuSoundsAuthoring>.NativeClassPtr, 100684544);
    }

    public StationMenuSoundsAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UISoundMapping SoundMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_SoundMapping));
        return pointer == IntPtr.Zero ? (UISoundMapping) null : new UISoundMapping(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_SoundMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UISoundType OpenSoundEvent
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_OpenSoundEvent));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_OpenSoundEvent)) = value;
      }
    }

    public unsafe UISoundType CloseSoundEvent
    {
      get
      {
        return *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_CloseSoundEvent));
      }
      [param: In] set
      {
        *(UISoundType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_CloseSoundEvent)) = value;
      }
    }

    public FmodEvent OpenSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_OpenSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_OpenSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public FmodEvent CloseSound
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_CloseSound);
        return new FmodEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StationMenuSoundsAuthoring.NativeFieldInfoPtr_CloseSound), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FmodEvent>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
