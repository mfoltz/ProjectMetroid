// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TutorialObjective_Building
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;

#nullable disable
namespace ProjectM.UI
{
  public class TutorialObjective_Building : TutorialObjective
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_TutorialObjectiveType_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateUINextFrame_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe TutorialObjectiveType Type
    {
      [CallerCount(24), CachedScanResults(RefRangeStart = 450995, RefRangeEnd = 451019, XrefRangeStart = 450995, XrefRangeEnd = 451019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialObjective_Building.NativeMethodInfoPtr_get_Type_Public_Virtual_get_TutorialObjectiveType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TutorialObjectiveType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    public override unsafe void UpdateUINextFrame()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialObjective_Building.NativeMethodInfoPtr_UpdateUINextFrame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276760, XrefRangeEnd = 1276761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective_Building.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1276761, XrefRangeEnd = 1276762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective_Building.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialObjective_Building()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective_Building.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TutorialObjective_Building()
    {
      Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TutorialObjective_Building));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr);
      TutorialObjective_Building.NativeMethodInfoPtr_get_Type_Public_Virtual_get_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr, 100668576);
      TutorialObjective_Building.NativeMethodInfoPtr_UpdateUINextFrame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr, 100668577);
      TutorialObjective_Building.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr, 100668578);
      TutorialObjective_Building.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr, 100668579);
      TutorialObjective_Building.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_Building>.NativeClassPtr, 100668580);
    }

    public TutorialObjective_Building(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
