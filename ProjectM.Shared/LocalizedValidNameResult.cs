// Decompiled with JetBrains decompiler
// Type: LocalizedValidNameResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using Project.Shared;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct LocalizedValidNameResult
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Result;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  [FieldOffset(0)]
  public ValidNameResult Result;
  [FieldOffset(4)]
  public LocalizationKey Name;

  static LocalizedValidNameResult()
  {
    Il2CppClassPointerStore<LocalizedValidNameResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "", nameof (LocalizedValidNameResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedValidNameResult>.NativeClassPtr);
    LocalizedValidNameResult.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedValidNameResult>.NativeClassPtr, nameof (Result));
    LocalizedValidNameResult.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedValidNameResult>.NativeClassPtr, nameof (Name));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalizedValidNameResult>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
