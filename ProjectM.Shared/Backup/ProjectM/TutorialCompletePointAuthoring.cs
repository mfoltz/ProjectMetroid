// Decompiled with JetBrains decompiler
// Type: ProjectM.TutorialCompletePointAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TutorialCompletePointAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LinkedTutorialAchievement;
    private static readonly IntPtr NativeFieldInfoPtr_TriggerRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727150, XrefRangeEnd = 727154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TutorialCompletePointAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialCompletePointAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialCompletePointAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TutorialCompletePointAuthoring()
    {
      Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TutorialCompletePointAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr);
      TutorialCompletePointAuthoring.NativeFieldInfoPtr_LinkedTutorialAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr, nameof (LinkedTutorialAchievement));
      TutorialCompletePointAuthoring.NativeFieldInfoPtr_TriggerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr, nameof (TriggerRange));
      TutorialCompletePointAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr, 100664311);
      TutorialCompletePointAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCompletePointAuthoring>.NativeClassPtr, 100664312);
    }

    public TutorialCompletePointAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGuidComponent LinkedTutorialAchievement
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompletePointAuthoring.NativeFieldInfoPtr_LinkedTutorialAchievement));
        return pointer == IntPtr.Zero ? (PrefabGuidComponent) null : new PrefabGuidComponent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompletePointAuthoring.NativeFieldInfoPtr_LinkedTutorialAchievement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float TriggerRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompletePointAuthoring.NativeFieldInfoPtr_TriggerRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialCompletePointAuthoring.NativeFieldInfoPtr_TriggerRange)) = value;
      }
    }
  }
}
