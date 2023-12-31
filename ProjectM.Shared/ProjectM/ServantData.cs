// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ServantData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ConvertDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReviveDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReviveCostModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsOnMission;
    [FieldOffset(0)]
    public float ConvertDuration;
    [FieldOffset(4)]
    public float ReviveDuration;
    [FieldOffset(8)]
    public float ReviveCostModifier;
    [FieldOffset(12)]
    public bool IsOnMission;

    static ServantData()
    {
      Il2CppClassPointerStore<ServantData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantData>.NativeClassPtr);
      ServantData.NativeFieldInfoPtr_ConvertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantData>.NativeClassPtr, nameof (ConvertDuration));
      ServantData.NativeFieldInfoPtr_ReviveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantData>.NativeClassPtr, nameof (ReviveDuration));
      ServantData.NativeFieldInfoPtr_ReviveCostModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantData>.NativeClassPtr, nameof (ReviveCostModifier));
      ServantData.NativeFieldInfoPtr_IsOnMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantData>.NativeClassPtr, nameof (IsOnMission));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
