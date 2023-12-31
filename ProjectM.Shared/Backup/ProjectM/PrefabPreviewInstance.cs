// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabPreviewInstance
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrefabPreviewInstance
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabOwnerObjectId;
    [FieldOffset(0)]
    public Entity Instance;
    [FieldOffset(8)]
    public int PrefabOwnerObjectId;

    static PrefabPreviewInstance()
    {
      Il2CppClassPointerStore<PrefabPreviewInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabPreviewInstance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPreviewInstance>.NativeClassPtr);
      PrefabPreviewInstance.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewInstance>.NativeClassPtr, nameof (Instance));
      PrefabPreviewInstance.NativeFieldInfoPtr_PrefabOwnerObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreviewInstance>.NativeClassPtr, nameof (PrefabOwnerObjectId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabPreviewInstance>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
