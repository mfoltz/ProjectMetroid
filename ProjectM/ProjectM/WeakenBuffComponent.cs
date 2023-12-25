// Decompiled with JetBrains decompiler
// Type: ProjectM.WeakenBuffComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class WeakenBuffComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_StackIncrease;
    private static readonly IntPtr NativeFieldInfoPtr_StackIncreaseModifier;
    private static readonly IntPtr NativeFieldInfoPtr_Weaken;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002311, XrefRangeEnd = 1002317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(WeakenBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WeakenBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WeakenBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WeakenBuffComponent()
    {
      Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WeakenBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr);
      WeakenBuffComponent.NativeFieldInfoPtr_StackIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr, nameof (StackIncrease));
      WeakenBuffComponent.NativeFieldInfoPtr_StackIncreaseModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr, nameof (StackIncreaseModifier));
      WeakenBuffComponent.NativeFieldInfoPtr_Weaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr, nameof (Weaken));
      WeakenBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr, 100677646);
      WeakenBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeakenBuffComponent>.NativeClassPtr, 100677647);
    }

    public WeakenBuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool StackIncrease
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeakenBuffComponent.NativeFieldInfoPtr_StackIncrease));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeakenBuffComponent.NativeFieldInfoPtr_StackIncrease)) = value;
      }
    }

    public unsafe float StackIncreaseModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeakenBuffComponent.NativeFieldInfoPtr_StackIncreaseModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeakenBuffComponent.NativeFieldInfoPtr_StackIncreaseModifier)) = value;
      }
    }

    public unsafe float Weaken
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeakenBuffComponent.NativeFieldInfoPtr_Weaken));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeakenBuffComponent.NativeFieldInfoPtr_Weaken)) = value;
      }
    }
  }
}
