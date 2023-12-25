// Decompiled with JetBrains decompiler
// Type: ProjectM.ImprisonedBuff
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ImprisonedBuff
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PreviousCellPosition;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBuffPrefabGuid;
    [FieldOffset(0)]
    public float2 PreviousCellPosition;
    [FieldOffset(8)]
    public PrefabGUID TeleportBuffPrefabGuid;

    static ImprisonedBuff()
    {
      Il2CppClassPointerStore<ImprisonedBuff>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ImprisonedBuff));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImprisonedBuff>.NativeClassPtr);
      ImprisonedBuff.NativeFieldInfoPtr_PreviousCellPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImprisonedBuff>.NativeClassPtr, nameof (PreviousCellPosition));
      ImprisonedBuff.NativeFieldInfoPtr_TeleportBuffPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImprisonedBuff>.NativeClassPtr, nameof (TeleportBuffPrefabGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImprisonedBuff>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
