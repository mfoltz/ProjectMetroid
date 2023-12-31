// Decompiled with JetBrains decompiler
// Type: ProjectM.GeneralGameplayCollection
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GeneralGameplayCollection
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_PerformanceInfoMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerIsRestartingMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerFailedSavingMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_AFKWarningMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ServerQAMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ClientQAMessage;
    [FieldOffset(0)]
    public LocalizationKey LKey_PerformanceInfoMessage;
    [FieldOffset(16)]
    public LocalizationKey LKey_ServerIsRestartingMessage;
    [FieldOffset(32)]
    public LocalizationKey LKey_ServerFailedSavingMessage;
    [FieldOffset(48)]
    public LocalizationKey LKey_AFKWarningMessage;
    [FieldOffset(64)]
    public LocalizationKey LKey_ServerQAMessage;
    [FieldOffset(80)]
    public LocalizationKey LKey_ClientQAMessage;

    static GeneralGameplayCollection()
    {
      Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GeneralGameplayCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr);
      GeneralGameplayCollection.NativeFieldInfoPtr_LKey_PerformanceInfoMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, nameof (LKey_PerformanceInfoMessage));
      GeneralGameplayCollection.NativeFieldInfoPtr_LKey_ServerIsRestartingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, nameof (LKey_ServerIsRestartingMessage));
      GeneralGameplayCollection.NativeFieldInfoPtr_LKey_ServerFailedSavingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, nameof (LKey_ServerFailedSavingMessage));
      GeneralGameplayCollection.NativeFieldInfoPtr_LKey_AFKWarningMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, nameof (LKey_AFKWarningMessage));
      GeneralGameplayCollection.NativeFieldInfoPtr_LKey_ServerQAMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, nameof (LKey_ServerQAMessage));
      GeneralGameplayCollection.NativeFieldInfoPtr_LKey_ClientQAMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, nameof (LKey_ClientQAMessage));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GeneralGameplayCollection>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
