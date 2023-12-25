// Decompiled with JetBrains decompiler
// Type: ProjectM.BuffAimPreview
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuffAimPreview
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPreviewPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DataSourceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimPreviewInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowForNonLocal;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowForTarget;
    [FieldOffset(0)]
    public PrefabGUID AimPreviewPrefab;
    [FieldOffset(4)]
    public PrefabGUID DataSourceGuid;
    [FieldOffset(8)]
    public Entity AimPreviewInstance;
    [FieldOffset(16)]
    public bool ShowForNonLocal;
    [FieldOffset(17)]
    public bool ShowForTarget;

    static BuffAimPreview()
    {
      Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BuffAimPreview));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr);
      BuffAimPreview.NativeFieldInfoPtr_AimPreviewPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr, nameof (AimPreviewPrefab));
      BuffAimPreview.NativeFieldInfoPtr_DataSourceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr, nameof (DataSourceGuid));
      BuffAimPreview.NativeFieldInfoPtr_AimPreviewInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr, nameof (AimPreviewInstance));
      BuffAimPreview.NativeFieldInfoPtr_ShowForNonLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr, nameof (ShowForNonLocal));
      BuffAimPreview.NativeFieldInfoPtr_ShowForTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr, nameof (ShowForTarget));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuffAimPreview>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
