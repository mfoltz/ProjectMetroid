// Decompiled with JetBrains decompiler
// Type: ProjectM.KnockbackAssetsSingleton
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct KnockbackAssetsSingleton
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_KnockbackBuffGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptBuffGuid;
    [FieldOffset(0)]
    public PrefabGUID KnockbackBuffGuid;
    [FieldOffset(4)]
    public PrefabGUID InterruptBuffGuid;

    static KnockbackAssetsSingleton()
    {
      Il2CppClassPointerStore<KnockbackAssetsSingleton>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (KnockbackAssetsSingleton));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnockbackAssetsSingleton>.NativeClassPtr);
      KnockbackAssetsSingleton.NativeFieldInfoPtr_KnockbackBuffGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackAssetsSingleton>.NativeClassPtr, nameof (KnockbackBuffGuid));
      KnockbackAssetsSingleton.NativeFieldInfoPtr_InterruptBuffGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnockbackAssetsSingleton>.NativeClassPtr, nameof (InterruptBuffGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KnockbackAssetsSingleton>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
