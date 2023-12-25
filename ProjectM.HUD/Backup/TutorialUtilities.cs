// Decompiled with JetBrains decompiler
// Type: TutorialUtilities
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.UI;
using StunShared.UI;

#nullable disable
public static class TutorialUtilities : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGenericTutorialUI_Internal_Static_Void_TutorialObjective_InputFlag_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompleteTutorialObjective_Public_Static_Void_TutorialObjectiveType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearTutorialObjectives_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasCompletedTutorials_Public_Static_Boolean_TutorialObjectiveType_0;

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 1207286, RefRangeEnd = 1207306, XrefRangeStart = 1207234, XrefRangeEnd = 1207286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpdateGenericTutorialUI(
    TutorialObjective tutorialObjective,
    InputFlag input)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tutorialObjective);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &input;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.NativeMethodInfoPtr_UpdateGenericTutorialUI_Internal_Static_Void_TutorialObjective_InputFlag_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 1207312, RefRangeEnd = 1207324, XrefRangeStart = 1207306, XrefRangeEnd = 1207312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CompleteTutorialObjective(TutorialObjectiveType tutorialObjective)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &tutorialObjective;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.NativeMethodInfoPtr_CompleteTutorialObjective_Public_Static_Void_TutorialObjectiveType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1207330, RefRangeEnd = 1207331, XrefRangeStart = 1207324, XrefRangeEnd = 1207330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClearTutorialObjectives()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.NativeMethodInfoPtr_ClearTutorialObjectives_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1207332, RefRangeEnd = 1207333, XrefRangeStart = 1207331, XrefRangeEnd = 1207332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasCompletedTutorials(TutorialObjectiveType tutorialObjective)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &tutorialObjective;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TutorialUtilities.NativeMethodInfoPtr_HasCompletedTutorials_Public_Static_Boolean_TutorialObjectiveType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static TutorialUtilities()
  {
    Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "", nameof (TutorialUtilities));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr);
    TutorialUtilities.NativeMethodInfoPtr_UpdateGenericTutorialUI_Internal_Static_Void_TutorialObjective_InputFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100663463);
    TutorialUtilities.NativeMethodInfoPtr_CompleteTutorialObjective_Public_Static_Void_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100663464);
    TutorialUtilities.NativeMethodInfoPtr_ClearTutorialObjectives_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100663465);
    TutorialUtilities.NativeMethodInfoPtr_HasCompletedTutorials_Public_Static_Boolean_TutorialObjectiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialUtilities>.NativeClassPtr, 100663466);
  }

  public TutorialUtilities(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
