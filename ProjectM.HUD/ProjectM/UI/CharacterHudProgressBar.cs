// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHudProgressBar
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CharacterHudProgressBar
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProgressBarId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
    [FieldOffset(0)]
    public float Progress;
    [FieldOffset(4)]
    public float MaxProgress;
    [FieldOffset(8)]
    public int ProgressBarId;
    [FieldOffset(12)]
    public int Importance;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1219601, RefRangeEnd = 1219603, XrefRangeStart = 1219601, XrefRangeEnd = 1219601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHudProgressBar.NativeMethodInfoPtr_Clear_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHudProgressBar()
    {
      Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHudProgressBar));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr);
      CharacterHudProgressBar.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr, nameof (Progress));
      CharacterHudProgressBar.NativeFieldInfoPtr_MaxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr, nameof (MaxProgress));
      CharacterHudProgressBar.NativeFieldInfoPtr_ProgressBarId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr, nameof (ProgressBarId));
      CharacterHudProgressBar.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr, nameof (Importance));
      CharacterHudProgressBar.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr, 100664516);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHudProgressBar>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
