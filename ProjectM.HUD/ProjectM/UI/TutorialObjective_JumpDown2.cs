// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TutorialObjective_JumpDown2
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
  public class TutorialObjective_JumpDown2 : TutorialObjective
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_TutorialObjectiveType_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateUINextFrame_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe TutorialObjectiveType Type
    {
      [CallerCount(48), CachedScanResults(RefRangeStart = 53682, RefRangeEnd = 53730, XrefRangeStart = 53682, XrefRangeEnd = 53730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialObjective_JumpDown2.NativeMethodInfoPtr_get_Type_Public_Virtual_get_TutorialObjectiveType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialObjective_JumpDown2.NativeMethodInfoPtr_UpdateUINextFrame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateUI()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective_JumpDown2.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective_JumpDown2.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TutorialObjective_JumpDown2()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TutorialObjective_JumpDown2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TutorialObjective_JumpDown2()
    {
      Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TutorialObjective_JumpDown2));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr);
      TutorialObjective_JumpDown2.NativeMethodInfoPtr_get_Type_Public_Virtual_get_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr, 100668596);
      TutorialObjective_JumpDown2.NativeMethodInfoPtr_UpdateUINextFrame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr, 100668597);
      TutorialObjective_JumpDown2.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr, 100668598);
      TutorialObjective_JumpDown2.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr, 100668599);
      TutorialObjective_JumpDown2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialObjective_JumpDown2>.NativeClassPtr, 100668600);
    }

    public TutorialObjective_JumpDown2(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
