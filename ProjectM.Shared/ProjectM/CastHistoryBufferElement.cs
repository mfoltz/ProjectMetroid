// Decompiled with JetBrains decompiler
// Type: ProjectM.CastHistoryBufferElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastHistoryBufferElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastResult;
    [FieldOffset(0)]
    public PrefabGUID AbilityPrefabGuid;
    [FieldOffset(8)]
    public double CastTime;
    [FieldOffset(16)]
    public CastHistoryCastResult CastResult;

    static CastHistoryBufferElement()
    {
      Il2CppClassPointerStore<CastHistoryBufferElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastHistoryBufferElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastHistoryBufferElement>.NativeClassPtr);
      CastHistoryBufferElement.NativeFieldInfoPtr_AbilityPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHistoryBufferElement>.NativeClassPtr, nameof (AbilityPrefabGuid));
      CastHistoryBufferElement.NativeFieldInfoPtr_CastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHistoryBufferElement>.NativeClassPtr, nameof (CastTime));
      CastHistoryBufferElement.NativeFieldInfoPtr_CastResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastHistoryBufferElement>.NativeClassPtr, nameof (CastResult));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastHistoryBufferElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
