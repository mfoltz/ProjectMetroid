// Decompiled with JetBrains decompiler
// Type: ProjectM.TutorialPointAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TutorialPointAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Objective;
    private static readonly IntPtr NativeFieldInfoPtr_TriggerRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727154, XrefRangeEnd = 727157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialPointAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727157, XrefRangeEnd = 727158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialPointAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialPointAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TutorialPointAuthoring()
    {
      Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TutorialPointAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr);
      TutorialPointAuthoring.NativeFieldInfoPtr_Objective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr, nameof (Objective));
      TutorialPointAuthoring.NativeFieldInfoPtr_TriggerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr, nameof (TriggerRange));
      TutorialPointAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr, 100664313);
      TutorialPointAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPointAuthoring>.NativeClassPtr, 100664314);
    }

    public TutorialPointAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TutorialObjectiveType Objective
    {
      get
      {
        return *(TutorialObjectiveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPointAuthoring.NativeFieldInfoPtr_Objective));
      }
      [param: In] set
      {
        *(TutorialObjectiveType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPointAuthoring.NativeFieldInfoPtr_Objective)) = value;
      }
    }

    public unsafe float TriggerRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPointAuthoring.NativeFieldInfoPtr_TriggerRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPointAuthoring.NativeFieldInfoPtr_TriggerRange)) = value;
      }
    }
  }
}
