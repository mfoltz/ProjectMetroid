// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabPreview
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrefabPreview
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DisableRendering;
    private static readonly System.IntPtr NativeFieldInfoPtr_SceneObjectLocalToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastSceneObjectLocalToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabOwnerObjectId;
    [FieldOffset(0)]
    public bool DisableRendering;
    [FieldOffset(4)]
    public float4x4 SceneObjectLocalToWorld;
    [FieldOffset(68)]
    public float4x4 LastSceneObjectLocalToWorld;
    [FieldOffset(132)]
    public PrefabGUID PrefabGUID;
    [FieldOffset(136)]
    public int PrefabOwnerObjectId;

    static PrefabPreview()
    {
      Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PrefabPreview));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr);
      PrefabPreview.NativeFieldInfoPtr_DisableRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr, nameof (DisableRendering));
      PrefabPreview.NativeFieldInfoPtr_SceneObjectLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr, nameof (SceneObjectLocalToWorld));
      PrefabPreview.NativeFieldInfoPtr_LastSceneObjectLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr, nameof (LastSceneObjectLocalToWorld));
      PrefabPreview.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr, nameof (PrefabGUID));
      PrefabPreview.NativeFieldInfoPtr_PrefabOwnerObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr, nameof (PrefabOwnerObjectId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabPreview>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
